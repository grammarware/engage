//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/grammarware/projects/engage/Engage/parsing/Engage.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Engage.parsing {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class EngageLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, ID=33, QUOTED=34, WHITESPACE=35, NEWLINE=36, COMMENT=37;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "ID", "QUOTED", 
		"WHITESPACE", "NEWLINE", "COMMENT"
	};


	public EngageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public EngageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'namespace'", "'types'", "'tokens'", "'handlers'", "','", "'<:'", 
		"';'", "'::'", "'number'", "'string'", "'->'", "'where'", "'BOF'", "'EOF'", 
		"'upon'", "'push'", "'('", "')'", "'wrap'", "'lift'", "'drop'", "'trim'", 
		"'*'", "'pass'", "':='", "'pop'", "'pop*'", "'pop#'", "'await'", "'with'", 
		"'await*'", "'tear'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "ID", "QUOTED", 
		"WHITESPACE", "NEWLINE", "COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Engage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static EngageLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\'', '\x10B', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'\"', '\x6', '\"', '\xE9', '\n', '\"', '\r', '\"', '\xE', '\"', '\xEA', 
		'\x3', '#', '\x3', '#', '\x6', '#', '\xEF', '\n', '#', '\r', '#', '\xE', 
		'#', '\xF0', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x6', '$', 
		'\xF7', '\n', '$', '\r', '$', '\xE', '$', '\xF8', '\x3', '$', '\x3', '$', 
		'\x3', '%', '\x5', '%', '\xFE', '\n', '%', '\x3', '%', '\x3', '%', '\x6', 
		'%', '\x102', '\n', '%', '\r', '%', '\xE', '%', '\x103', '\x3', '&', '\x3', 
		'&', '\x6', '&', '\x108', '\n', '&', '\r', '&', '\xE', '&', '\x109', '\x2', 
		'\x2', '\'', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', 
		'\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', 
		'\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', 
		'\x41', '\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 
		'\x3', '\x2', '\x6', '\a', '\x2', '%', '%', '\x32', ';', '\x43', '\\', 
		'\x61', '\x61', '\x63', '|', '\x3', '\x2', ')', ')', '\x6', '\x2', '\v', 
		'\f', '\xF', '\xF', '\"', '\"', '\xA2', '\xA2', '\x4', '\x2', '\f', '\f', 
		'\xF', '\xF', '\x2', '\x112', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x3', 'M', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'W', '\x3', '\x2', '\x2', '\x2', '\a', ']', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x64', '\x3', '\x2', '\x2', '\x2', '\v', 'm', '\x3', '\x2', '\x2', 
		'\x2', '\r', 'o', '\x3', '\x2', '\x2', '\x2', '\xF', 'r', '\x3', '\x2', 
		'\x2', '\x2', '\x11', 't', '\x3', '\x2', '\x2', '\x2', '\x13', 'w', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '~', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'\x85', '\x3', '\x2', '\x2', '\x2', '\x19', '\x88', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x92', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\x96', '\x3', '\x2', '\x2', '\x2', '!', 
		'\x9B', '\x3', '\x2', '\x2', '\x2', '#', '\xA0', '\x3', '\x2', '\x2', 
		'\x2', '%', '\xA2', '\x3', '\x2', '\x2', '\x2', '\'', '\xA4', '\x3', '\x2', 
		'\x2', '\x2', ')', '\xA9', '\x3', '\x2', '\x2', '\x2', '+', '\xAE', '\x3', 
		'\x2', '\x2', '\x2', '-', '\xB3', '\x3', '\x2', '\x2', '\x2', '/', '\xB8', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\xBA', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\xBF', '\x3', '\x2', '\x2', '\x2', '\x35', '\xC2', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\xC6', '\x3', '\x2', '\x2', '\x2', '\x39', '\xCB', 
		'\x3', '\x2', '\x2', '\x2', ';', '\xD0', '\x3', '\x2', '\x2', '\x2', '=', 
		'\xD6', '\x3', '\x2', '\x2', '\x2', '?', '\xDB', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\xE2', '\x3', '\x2', '\x2', '\x2', '\x43', '\xE8', '\x3', 
		'\x2', '\x2', '\x2', '\x45', '\xEC', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\xF6', '\x3', '\x2', '\x2', '\x2', 'I', '\x101', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\x105', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', 'p', 
		'\x2', '\x2', 'N', 'O', '\a', '\x63', '\x2', '\x2', 'O', 'P', '\a', 'o', 
		'\x2', '\x2', 'P', 'Q', '\a', 'g', '\x2', '\x2', 'Q', 'R', '\a', 'u', 
		'\x2', '\x2', 'R', 'S', '\a', 'r', '\x2', '\x2', 'S', 'T', '\a', '\x63', 
		'\x2', '\x2', 'T', 'U', '\a', '\x65', '\x2', '\x2', 'U', 'V', '\a', 'g', 
		'\x2', '\x2', 'V', '\x4', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 
		'v', '\x2', '\x2', 'X', 'Y', '\a', '{', '\x2', '\x2', 'Y', 'Z', '\a', 
		'r', '\x2', '\x2', 'Z', '[', '\a', 'g', '\x2', '\x2', '[', '\\', '\a', 
		'u', '\x2', '\x2', '\\', '\x6', '\x3', '\x2', '\x2', '\x2', ']', '^', 
		'\a', 'v', '\x2', '\x2', '^', '_', '\a', 'q', '\x2', '\x2', '_', '`', 
		'\a', 'm', '\x2', '\x2', '`', '\x61', '\a', 'g', '\x2', '\x2', '\x61', 
		'\x62', '\a', 'p', '\x2', '\x2', '\x62', '\x63', '\a', 'u', '\x2', '\x2', 
		'\x63', '\b', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', 'j', '\x2', 
		'\x2', '\x65', '\x66', '\a', '\x63', '\x2', '\x2', '\x66', 'g', '\a', 
		'p', '\x2', '\x2', 'g', 'h', '\a', '\x66', '\x2', '\x2', 'h', 'i', '\a', 
		'n', '\x2', '\x2', 'i', 'j', '\a', 'g', '\x2', '\x2', 'j', 'k', '\a', 
		't', '\x2', '\x2', 'k', 'l', '\a', 'u', '\x2', '\x2', 'l', '\n', '\x3', 
		'\x2', '\x2', '\x2', 'm', 'n', '\a', '.', '\x2', '\x2', 'n', '\f', '\x3', 
		'\x2', '\x2', '\x2', 'o', 'p', '\a', '>', '\x2', '\x2', 'p', 'q', '\a', 
		'<', '\x2', '\x2', 'q', '\xE', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', 
		'=', '\x2', '\x2', 's', '\x10', '\x3', '\x2', '\x2', '\x2', 't', 'u', 
		'\a', '<', '\x2', '\x2', 'u', 'v', '\a', '<', '\x2', '\x2', 'v', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', 'p', '\x2', '\x2', 'x', 'y', 
		'\a', 'w', '\x2', '\x2', 'y', 'z', '\a', 'o', '\x2', '\x2', 'z', '{', 
		'\a', '\x64', '\x2', '\x2', '{', '|', '\a', 'g', '\x2', '\x2', '|', '}', 
		'\a', 't', '\x2', '\x2', '}', '\x14', '\x3', '\x2', '\x2', '\x2', '~', 
		'\x7F', '\a', 'u', '\x2', '\x2', '\x7F', '\x80', '\a', 'v', '\x2', '\x2', 
		'\x80', '\x81', '\a', 't', '\x2', '\x2', '\x81', '\x82', '\a', 'k', '\x2', 
		'\x2', '\x82', '\x83', '\a', 'p', '\x2', '\x2', '\x83', '\x84', '\a', 
		'i', '\x2', '\x2', '\x84', '\x16', '\x3', '\x2', '\x2', '\x2', '\x85', 
		'\x86', '\a', '/', '\x2', '\x2', '\x86', '\x87', '\a', '@', '\x2', '\x2', 
		'\x87', '\x18', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\a', 'y', 
		'\x2', '\x2', '\x89', '\x8A', '\a', 'j', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'g', '\x2', '\x2', '\x8B', '\x8C', '\a', 't', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', 'g', '\x2', '\x2', '\x8D', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x8E', '\x8F', '\a', '\x44', '\x2', '\x2', '\x8F', '\x90', '\a', 
		'Q', '\x2', '\x2', '\x90', '\x91', '\a', 'H', '\x2', '\x2', '\x91', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', 'G', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'Q', '\x2', '\x2', '\x94', '\x95', '\a', 'H', '\x2', '\x2', 
		'\x95', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\a', 'w', 
		'\x2', '\x2', '\x97', '\x98', '\a', 'r', '\x2', '\x2', '\x98', '\x99', 
		'\a', 'q', '\x2', '\x2', '\x99', '\x9A', '\a', 'p', '\x2', '\x2', '\x9A', 
		' ', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', 'r', '\x2', '\x2', 
		'\x9C', '\x9D', '\a', 'w', '\x2', '\x2', '\x9D', '\x9E', '\a', 'u', '\x2', 
		'\x2', '\x9E', '\x9F', '\a', 'j', '\x2', '\x2', '\x9F', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\xA0', '\xA1', '\a', '*', '\x2', '\x2', '\xA1', '$', '\x3', 
		'\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', '+', '\x2', '\x2', '\xA3', 
		'&', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\a', 'y', '\x2', '\x2', 
		'\xA5', '\xA6', '\a', 't', '\x2', '\x2', '\xA6', '\xA7', '\a', '\x63', 
		'\x2', '\x2', '\xA7', '\xA8', '\a', 'r', '\x2', '\x2', '\xA8', '(', '\x3', 
		'\x2', '\x2', '\x2', '\xA9', '\xAA', '\a', 'n', '\x2', '\x2', '\xAA', 
		'\xAB', '\a', 'k', '\x2', '\x2', '\xAB', '\xAC', '\a', 'h', '\x2', '\x2', 
		'\xAC', '\xAD', '\a', 'v', '\x2', '\x2', '\xAD', '*', '\x3', '\x2', '\x2', 
		'\x2', '\xAE', '\xAF', '\a', '\x66', '\x2', '\x2', '\xAF', '\xB0', '\a', 
		't', '\x2', '\x2', '\xB0', '\xB1', '\a', 'q', '\x2', '\x2', '\xB1', '\xB2', 
		'\a', 'r', '\x2', '\x2', '\xB2', ',', '\x3', '\x2', '\x2', '\x2', '\xB3', 
		'\xB4', '\a', 'v', '\x2', '\x2', '\xB4', '\xB5', '\a', 't', '\x2', '\x2', 
		'\xB5', '\xB6', '\a', 'k', '\x2', '\x2', '\xB6', '\xB7', '\a', 'o', '\x2', 
		'\x2', '\xB7', '.', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\a', 
		',', '\x2', '\x2', '\xB9', '\x30', '\x3', '\x2', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', 'r', '\x2', '\x2', '\xBB', '\xBC', '\a', '\x63', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', 'u', '\x2', '\x2', '\xBD', '\xBE', '\a', 
		'u', '\x2', '\x2', '\xBE', '\x32', '\x3', '\x2', '\x2', '\x2', '\xBF', 
		'\xC0', '\a', '<', '\x2', '\x2', '\xC0', '\xC1', '\a', '?', '\x2', '\x2', 
		'\xC1', '\x34', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC3', '\a', 'r', 
		'\x2', '\x2', '\xC3', '\xC4', '\a', 'q', '\x2', '\x2', '\xC4', '\xC5', 
		'\a', 'r', '\x2', '\x2', '\xC5', '\x36', '\x3', '\x2', '\x2', '\x2', '\xC6', 
		'\xC7', '\a', 'r', '\x2', '\x2', '\xC7', '\xC8', '\a', 'q', '\x2', '\x2', 
		'\xC8', '\xC9', '\a', 'r', '\x2', '\x2', '\xC9', '\xCA', '\a', ',', '\x2', 
		'\x2', '\xCA', '\x38', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCC', '\a', 
		'r', '\x2', '\x2', '\xCC', '\xCD', '\a', 'q', '\x2', '\x2', '\xCD', '\xCE', 
		'\a', 'r', '\x2', '\x2', '\xCE', '\xCF', '\a', '%', '\x2', '\x2', '\xCF', 
		':', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', '\x63', '\x2', 
		'\x2', '\xD1', '\xD2', '\a', 'y', '\x2', '\x2', '\xD2', '\xD3', '\a', 
		'\x63', '\x2', '\x2', '\xD3', '\xD4', '\a', 'k', '\x2', '\x2', '\xD4', 
		'\xD5', '\a', 'v', '\x2', '\x2', '\xD5', '<', '\x3', '\x2', '\x2', '\x2', 
		'\xD6', '\xD7', '\a', 'y', '\x2', '\x2', '\xD7', '\xD8', '\a', 'k', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', 'v', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'j', '\x2', '\x2', '\xDA', '>', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDC', 
		'\a', '\x63', '\x2', '\x2', '\xDC', '\xDD', '\a', 'y', '\x2', '\x2', '\xDD', 
		'\xDE', '\a', '\x63', '\x2', '\x2', '\xDE', '\xDF', '\a', 'k', '\x2', 
		'\x2', '\xDF', '\xE0', '\a', 'v', '\x2', '\x2', '\xE0', '\xE1', '\a', 
		',', '\x2', '\x2', '\xE1', '@', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', 
		'\a', 'v', '\x2', '\x2', '\xE3', '\xE4', '\a', 'g', '\x2', '\x2', '\xE4', 
		'\xE5', '\a', '\x63', '\x2', '\x2', '\xE5', '\xE6', '\a', 't', '\x2', 
		'\x2', '\xE6', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE9', '\t', 
		'\x2', '\x2', '\x2', '\xE8', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xEA', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xE8', '\x3', '\x2', '\x2', 
		'\x2', '\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xEE', '\a', ')', '\x2', '\x2', '\xED', 
		'\xEF', '\n', '\x3', '\x2', '\x2', '\xEE', '\xED', '\x3', '\x2', '\x2', 
		'\x2', '\xEF', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xEE', '\x3', 
		'\x2', '\x2', '\x2', '\xF0', '\xF1', '\x3', '\x2', '\x2', '\x2', '\xF1', 
		'\xF2', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', '\a', ')', '\x2', 
		'\x2', '\xF3', '\x46', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF7', '\t', 
		'\x4', '\x2', '\x2', '\xF5', '\xF7', '\x5', 'K', '&', '\x2', '\xF6', '\xF4', 
		'\x3', '\x2', '\x2', '\x2', '\xF6', '\xF5', '\x3', '\x2', '\x2', '\x2', 
		'\xF7', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF6', '\x3', '\x2', 
		'\x2', '\x2', '\xF8', '\xF9', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', 
		'\x3', '\x2', '\x2', '\x2', '\xFA', '\xFB', '\b', '$', '\x2', '\x2', '\xFB', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFE', '\a', '\xF', '\x2', '\x2', 
		'\xFD', '\xFC', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFE', '\x3', '\x2', 
		'\x2', '\x2', '\xFE', '\xFF', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x102', 
		'\a', '\f', '\x2', '\x2', '\x100', '\x102', '\a', '\xF', '\x2', '\x2', 
		'\x101', '\xFD', '\x3', '\x2', '\x2', '\x2', '\x101', '\x100', '\x3', 
		'\x2', '\x2', '\x2', '\x102', '\x103', '\x3', '\x2', '\x2', '\x2', '\x103', 
		'\x101', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', '\x3', '\x2', '\x2', 
		'\x2', '\x104', 'J', '\x3', '\x2', '\x2', '\x2', '\x105', '\x107', '\a', 
		'\'', '\x2', '\x2', '\x106', '\x108', '\n', '\x5', '\x2', '\x2', '\x107', 
		'\x106', '\x3', '\x2', '\x2', '\x2', '\x108', '\x109', '\x3', '\x2', '\x2', 
		'\x2', '\x109', '\x107', '\x3', '\x2', '\x2', '\x2', '\x109', '\x10A', 
		'\x3', '\x2', '\x2', '\x2', '\x10A', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\x2', '\xEA', '\xF0', '\xF6', '\xF8', '\xFD', '\x101', '\x103', 
		'\x109', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Engage.parsing
