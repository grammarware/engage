﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using EAX;
using EaxOpenClose;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngageTests
{
    [TestClass]
    public class ManyTests
    {
        private static readonly Stopwatch Timer = new Stopwatch();
        private int _dump;

        [TestMethod]
        [TestCategory("EAX")]
        public void TestXmlShallowPerformance()
        {
            const int maxLimit = 1000; // the higher, the longer test time and the higher chances to crash
            const int maxReruns = 20; // the higher, the smoother

            // all the limits/depths/… we will use
            var limits = Enumerable.Range(1, maxLimit).Where(n => n % 10 == 0).ToList();
            var length = limits.Count;
            // prepare to collect data
            var ticksSax = new List<List<long>>();
            var ticksEax = new List<List<long>>();
            var ticksEaz = new List<List<long>>();
            var ticksCax = new List<List<long>>();
            var ticksFax = new List<List<long>>();

            for (var i = 0; i < length; i++)
            {
                ticksSax.Add(new List<long>());
                ticksEax.Add(new List<long>());
                ticksEaz.Add(new List<long>());
                ticksCax.Add(new List<long>());
                ticksFax.Add(new List<long>());
            }

            // run several times 
            for (var i = 0; i < maxReruns; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    string input = GenerateShallowTestInput(limits[j]);
                    ticksSax[j].Add(TimeCountSaxShallow(input));
                    ticksEax[j].Add(TimeCountEaxShallow(input));
                    ticksEaz[j].Add(TimeCountEazShallow(input));
                    ticksCax[j].Add(TimeCountCaxShallow(input));
                    ticksFax[j].Add(TimeCountFaxShallow(input));
                }
            }

            // print only the median from each measurement
            PrintResults(limits,
                ticksSax.Select(Median),
                ticksEax.Select(Median),
                ticksEaz.Select(Median),
                ticksCax.Select(Median),
                ticksFax.Select(Median));
        }

        [TestMethod]
        [TestCategory("EAX")]
        public void TestXmlShallowCorrectness()
        {
            const int maxLimit = 1000; // the higher, the longer test time and the higher chances to crash
            const int maxReruns = 50; // the higher, the more thorough

            // all the limits/depths/… we will use
            var limits = Enumerable.Range(1, maxLimit).Where(n => n % 10 == 0).ToList();
            var length = limits.Count;

            // run several times 
            for (var i = 0; i < maxReruns; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    string input = GenerateShallowTestInput(limits[j]);
                    Assert.IsTrue(CompareSaxEaxShallow(input));
                }
            }
        }

        private static long Median(IEnumerable<long> list)
        {
            long[] array = list.ToArray();
            Array.Sort(array);
            var size = array.Length;
            var middle = size / 2;
            if (size % 2 == 0)
                return (long)((array[middle] + (double)array[middle - 1]) / 2);
            return array[middle];
        }

        private static void PrintResults(IEnumerable<int> limits, params IEnumerable<long>[] tickses)
        {
            Console.WriteLine($"Limits: [{CommaSep(limits)}]");
            var cx = 1;
            foreach (var ticks in tickses)
                Console.WriteLine($"Times{cx++}: [{CommaSep(ticks)}]");
        }

        private static string CommaSep<T>(IEnumerable<T> list)
            => String.Join(", ", list.Select(e => e.ToString()));

        private long TimeCountSaxShallow(string input)
        {
            HashSet<string> tags = new HashSet<string>();

            Timer.Restart();

            using (XmlReader reader = XmlReader.Create(new StringReader(input)))
            {
                reader.MoveToContent();
                while (reader.Read())
                    tags.Add(reader.Name);
            }

            Timer.Stop();
            // Console.WriteLine($"Tags found: {tags.Count}");
            _dump = tags.Count;

            return Timer.ElapsedTicks;
        }

        private long TimeCountEaxShallow(string input)
        {
            HashSet<string> tags = new HashSet<string>();

            Timer.Restart();

            var result = Parsers.ParseOpenClose(input);

            foreach (var tag in result.tags)
            {
                if (tag is TagOpen oTag)
                    tags.Add(oTag.n.value);
            }

            Timer.Stop();
            // Console.WriteLine($"Tags found: {tags.Count}");
            _dump = tags.Count;

            return Timer.ElapsedTicks;
        }

        private long TimeCountEazShallow(string input)
        {
            HashSet<string> tags = new HashSet<string>();

            Timer.Restart();

            var result = Parsers.ParseOpenCloseX(input);

            foreach (var tag in result.tags)
            {
                if (tag is TagOpen oTag)
                    tags.Add(oTag.n.value);
            }

            Timer.Stop();
            // Console.WriteLine($"Tags found: {tags.Count}");
            _dump = tags.Count;

            return Timer.ElapsedTicks;
        }

        private long TimeCountCaxShallow(string input)
        {
            HashSet<string> tags = new HashSet<string>();

            Timer.Restart();

            var result = Parsers.ParseOpenCloseC(input);

            foreach (var tag in result.tags)
            {
                if (tag is TagOpen oTag)
                    tags.Add(oTag.n.value);
            }

            Timer.Stop();
            // Console.WriteLine($"Tags found: {tags.Count}");
            _dump = tags.Count;

            return Timer.ElapsedTicks;
        }

        private long TimeCountFaxShallow(string input)
        {
            HashSet<string> tags = new HashSet<string>();

            Timer.Restart();

            var result = Parsers.ParseOpenCloseF(input);

            Timer.Stop();
            // Console.WriteLine($"Tags found: {tags.Count}");
            _dump = result.Count;

            return Timer.ElapsedTicks;
        }

        private bool CompareSaxEaxShallow(string input)
        {
            HashSet<string> tagsSax = new HashSet<string>();
            HashSet<string> tagsEax = new HashSet<string>();
            HashSet<string> tagsEaz = new HashSet<string>();

            using (XmlReader reader = XmlReader.Create(new StringReader(input)))
            {
                reader.MoveToContent();
                while (reader.Read())
                    tagsSax.Add(reader.Name);
            }

            foreach (var tag in Parsers.ParseOpenClose(input).tags)
            {
                if (tag is TagOpen oTag)
                    tagsEax.Add(oTag.n.value);
            }

            foreach (var tag in Parsers.ParseOpenCloseX(input).tags)
            {
                if (tag is TagOpen oTag)
                    tagsEaz.Add(oTag.n.value);
            }

            return tagsEax.SetEquals(tagsSax) && tagsEax.SetEquals(tagsEaz);
        }

        private static string GenerateShallowTestInput(int limit)
            => Generator.ArbitraryBalancedSequenceShallow(limit);
    }
}