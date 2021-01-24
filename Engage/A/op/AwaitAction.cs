﻿using System;
using System.Collections.Generic;

namespace Engage.A
{
    public class AwaitAction : Reaction
    {
        public string TmpContext = "";
        public string ExtraContext = "";

        public override bool Equals(object obj)
        {
            var other = obj as AwaitAction;
            if (other == null)
            {
                Console.WriteLine("[x] AwaitAction compared to non-AwaitAction");
                return false;
            }

            if (Name != other.Name)
            {
                Console.WriteLine($"[x] AwaitAction: Name mismatch ({Name} vs {other.Name})");
                return false;
            }

            if (TmpContext != other.TmpContext)
            {
                Console.WriteLine("[x] AwaitAction: TmpContext mismatch");
                return false;
            }

            if (ExtraContext != other.ExtraContext)
            {
                Console.WriteLine("[x] AwaitAction: ExtraContext mismatch");
                return false;
            }

            Console.WriteLine("[√] AwaitAction == AwaitAction");
            return true;
        }

        public override B.HandleAction ToHandleAction(string target = "", B.HandleAction prev = null)
        {
            var a = new B.AwaitOne
            {
                Name = B.SystemPlan.Dealias(Name),
                Target = target,
                Flag = TmpContext,
                ExtraFlag = ExtraContext,
                BaseAction = prev
            };
            return a;
        }

        internal override IEnumerable<string> GetFlags()
            => new List<string>() {TmpContext, ExtraContext};
    }
}