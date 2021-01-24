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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class EngageParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, ID=33, QUOTED=34, WHITESPACE=35, NEWLINE=36, COMMENT=37;
	public const int
		RULE_engSpec = 0, RULE_typeDecl = 1, RULE_superType = 2, RULE_tokenDecl = 3, 
		RULE_lexeme = 4, RULE_handlerDecl = 5, RULE_trigger = 6, RULE_reaction = 7, 
		RULE_name = 8, RULE_assignment = 9, RULE_operation = 10;
	public static readonly string[] ruleNames = {
		"engSpec", "typeDecl", "superType", "tokenDecl", "lexeme", "handlerDecl", 
		"trigger", "reaction", "name", "assignment", "operation"
	};

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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static EngageParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public EngageParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public EngageParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class EngSpecContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(EngageParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeDeclContext[] typeDecl() {
			return GetRuleContexts<TypeDeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeDeclContext typeDecl(int i) {
			return GetRuleContext<TypeDeclContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TokenDeclContext[] tokenDecl() {
			return GetRuleContexts<TokenDeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TokenDeclContext tokenDecl(int i) {
			return GetRuleContext<TokenDeclContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public HandlerDeclContext[] handlerDecl() {
			return GetRuleContexts<HandlerDeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public HandlerDeclContext handlerDecl(int i) {
			return GetRuleContext<HandlerDeclContext>(i);
		}
		public EngSpecContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_engSpec; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterEngSpec(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitEngSpec(this);
		}
	}

	[RuleVersion(0)]
	public EngSpecContext engSpec() {
		EngSpecContext _localctx = new EngSpecContext(Context, State);
		EnterRule(_localctx, 0, RULE_engSpec);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22; Match(T__0);
			State = 23; Match(ID);
			State = 24; Match(T__1);
			State = 28;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==ID) {
				{
				{
				State = 25; typeDecl();
				}
				}
				State = 30;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 31; Match(T__2);
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__9) | (1L << QUOTED))) != 0)) {
				{
				{
				State = 32; tokenDecl();
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 38; Match(T__3);
			State = 42;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__12) | (1L << T__13) | (1L << ID) | (1L << QUOTED))) != 0)) {
				{
				{
				State = 39; handlerDecl();
				}
				}
				State = 44;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeDeclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(EngageParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(EngageParser.ID, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SuperTypeContext superType() {
			return GetRuleContext<SuperTypeContext>(0);
		}
		public TypeDeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeDecl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterTypeDecl(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitTypeDecl(this);
		}
	}

	[RuleVersion(0)]
	public TypeDeclContext typeDecl() {
		TypeDeclContext _localctx = new TypeDeclContext(Context, State);
		EnterRule(_localctx, 2, RULE_typeDecl);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45; Match(ID);
			State = 50;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__4) {
				{
				{
				State = 46; Match(T__4);
				State = 47; Match(ID);
				}
				}
				State = 52;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__5) {
				{
				State = 53; Match(T__5);
				State = 54; superType();
				}
			}

			State = 57; Match(T__6);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SuperTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(EngageParser.ID, 0); }
		public SuperTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_superType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterSuperType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitSuperType(this);
		}
	}

	[RuleVersion(0)]
	public SuperTypeContext superType() {
		SuperTypeContext _localctx = new SuperTypeContext(Context, State);
		EnterRule(_localctx, 4, RULE_superType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 59; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TokenDeclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LexemeContext[] lexeme() {
			return GetRuleContexts<LexemeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public LexemeContext lexeme(int i) {
			return GetRuleContext<LexemeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(EngageParser.ID, 0); }
		public TokenDeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tokenDecl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterTokenDecl(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitTokenDecl(this);
		}
	}

	[RuleVersion(0)]
	public TokenDeclContext tokenDecl() {
		TokenDeclContext _localctx = new TokenDeclContext(Context, State);
		EnterRule(_localctx, 6, RULE_tokenDecl);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 61; lexeme();
			State = 66;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__4) {
				{
				{
				State = 62; Match(T__4);
				State = 63; lexeme();
				}
				}
				State = 68;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 69; Match(T__7);
			State = 70; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LexemeContext : ParserRuleContext {
		public IToken Q;
		public IToken N;
		public IToken S;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUOTED() { return GetToken(EngageParser.QUOTED, 0); }
		public LexemeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lexeme; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterLexeme(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitLexeme(this);
		}
	}

	[RuleVersion(0)]
	public LexemeContext lexeme() {
		LexemeContext _localctx = new LexemeContext(Context, State);
		EnterRule(_localctx, 8, RULE_lexeme);
		try {
			State = 75;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case QUOTED:
				EnterOuterAlt(_localctx, 1);
				{
				State = 72; _localctx.Q = Match(QUOTED);
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 2);
				{
				State = 73; _localctx.N = Match(T__8);
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 3);
				{
				State = 74; _localctx.S = Match(T__9);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HandlerDeclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TriggerContext trigger() {
			return GetRuleContext<TriggerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReactionContext reaction() {
			return GetRuleContext<ReactionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext[] assignment() {
			return GetRuleContexts<AssignmentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment(int i) {
			return GetRuleContext<AssignmentContext>(i);
		}
		public HandlerDeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_handlerDecl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterHandlerDecl(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitHandlerDecl(this);
		}
	}

	[RuleVersion(0)]
	public HandlerDeclContext handlerDecl() {
		HandlerDeclContext _localctx = new HandlerDeclContext(Context, State);
		EnterRule(_localctx, 10, RULE_handlerDecl);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 77; trigger();
			State = 78; Match(T__10);
			State = 79; reaction();
			State = 89;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__11) {
				{
				State = 80; Match(T__11);
				State = 81; assignment();
				State = 86;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__4) {
					{
					{
					State = 82; Match(T__4);
					State = 83; assignment();
					}
					}
					State = 88;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TriggerContext : ParserRuleContext {
		public IToken T;
		public IToken Bof;
		public IToken Eof;
		public IToken NT;
		public IToken Flag;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUOTED() { return GetToken(EngageParser.QUOTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(EngageParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(EngageParser.ID, i);
		}
		public TriggerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trigger; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterTrigger(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitTrigger(this);
		}
	}

	[RuleVersion(0)]
	public TriggerContext trigger() {
		TriggerContext _localctx = new TriggerContext(Context, State);
		EnterRule(_localctx, 12, RULE_trigger);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 95;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case QUOTED:
				{
				State = 91; _localctx.T = Match(QUOTED);
				}
				break;
			case T__12:
				{
				State = 92; _localctx.Bof = Match(T__12);
				}
				break;
			case T__13:
				{
				State = 93; _localctx.Eof = Match(T__13);
				}
				break;
			case ID:
				{
				State = 94; _localctx.NT = Match(ID);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 99;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__14) {
				{
				State = 97; Match(T__14);
				State = 98; _localctx.Flag = Match(ID);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ReactionContext : ParserRuleContext {
		public IToken Command;
		public IToken Star;
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(EngageParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(EngageParser.ID, i);
		}
		public ReactionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_reaction; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterReaction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitReaction(this);
		}
	}

	[RuleVersion(0)]
	public ReactionContext reaction() {
		ReactionContext _localctx = new ReactionContext(Context, State);
		EnterRule(_localctx, 14, RULE_reaction);
		int _la;
		try {
			State = 139;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__15:
				EnterOuterAlt(_localctx, 1);
				{
				State = 101; _localctx.Command = Match(T__15);
				State = 102; name();
				State = 113;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__16) {
					{
					State = 103; Match(T__16);
					State = 104; Match(ID);
					State = 109;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==T__4) {
						{
						{
						State = 105; Match(T__4);
						State = 106; Match(ID);
						}
						}
						State = 111;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 112; Match(T__17);
					}
				}

				}
				break;
			case T__18:
				EnterOuterAlt(_localctx, 2);
				{
				State = 115; _localctx.Command = Match(T__18);
				State = 116; name();
				State = 127;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__16) {
					{
					State = 117; Match(T__16);
					State = 118; Match(ID);
					State = 123;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==T__4) {
						{
						{
						State = 119; Match(T__4);
						State = 120; Match(ID);
						}
						}
						State = 125;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 126; Match(T__17);
					}
				}

				}
				break;
			case T__19:
				EnterOuterAlt(_localctx, 3);
				{
				State = 129; _localctx.Command = Match(T__19);
				State = 130; Match(ID);
				}
				break;
			case T__20:
				EnterOuterAlt(_localctx, 4);
				{
				State = 131; _localctx.Command = Match(T__20);
				State = 132; Match(ID);
				}
				break;
			case T__21:
				EnterOuterAlt(_localctx, 5);
				{
				State = 133; _localctx.Command = Match(T__21);
				State = 134; Match(ID);
				State = 136;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__22) {
					{
					State = 135; _localctx.Star = Match(T__22);
					}
				}

				}
				break;
			case T__23:
				EnterOuterAlt(_localctx, 6);
				{
				State = 138; _localctx.Command = Match(T__23);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(EngageParser.ID, 0); }
		public NameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitName(this);
		}
	}

	[RuleVersion(0)]
	public NameContext name() {
		NameContext _localctx = new NameContext(Context, State);
		EnterRule(_localctx, 16, RULE_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 141; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(EngageParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public OperationContext operation() {
			return GetRuleContext<OperationContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 18, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 143; Match(ID);
			State = 144; Match(T__24);
			State = 145; operation();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperationContext : ParserRuleContext {
		public IToken Command;
		public IToken Name;
		public IToken ExtraContext;
		public IToken LocalContext;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(EngageParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(EngageParser.ID, i);
		}
		public OperationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.EnterOperation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IEngageListener typedListener = listener as IEngageListener;
			if (typedListener != null) typedListener.ExitOperation(this);
		}
	}

	[RuleVersion(0)]
	public OperationContext operation() {
		OperationContext _localctx = new OperationContext(Context, State);
		EnterRule(_localctx, 20, RULE_operation);
		int _la;
		try {
			State = 174;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__25:
				EnterOuterAlt(_localctx, 1);
				{
				State = 147; _localctx.Command = Match(T__25);
				State = 148; _localctx.Name = Match(ID);
				}
				break;
			case T__26:
				EnterOuterAlt(_localctx, 2);
				{
				State = 149; _localctx.Command = Match(T__26);
				State = 150; _localctx.Name = Match(ID);
				}
				break;
			case T__27:
				EnterOuterAlt(_localctx, 3);
				{
				State = 151; _localctx.Command = Match(T__27);
				State = 152; _localctx.Name = Match(ID);
				}
				break;
			case T__28:
				EnterOuterAlt(_localctx, 4);
				{
				State = 153; _localctx.Command = Match(T__28);
				State = 160;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ID:
					{
					{
					State = 154; _localctx.Name = Match(ID);
					}
					}
					break;
				case T__16:
					{
					{
					State = 155; Match(T__16);
					State = 156; _localctx.Name = Match(ID);
					State = 157; Match(T__14);
					State = 158; _localctx.ExtraContext = Match(ID);
					State = 159; Match(T__17);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 164;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__29) {
					{
					State = 162; Match(T__29);
					State = 163; _localctx.LocalContext = Match(ID);
					}
				}

				}
				break;
			case T__30:
				EnterOuterAlt(_localctx, 5);
				{
				State = 166; _localctx.Command = Match(T__30);
				State = 167; _localctx.Name = Match(ID);
				State = 170;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__29) {
					{
					State = 168; Match(T__29);
					State = 169; _localctx.LocalContext = Match(ID);
					}
				}

				}
				break;
			case T__31:
				EnterOuterAlt(_localctx, 6);
				{
				State = 172; _localctx.Command = Match(T__31);
				State = 173; _localctx.Name = Match(ID);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\'', '\xB3', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\a', '\x2', '\x1D', '\n', '\x2', '\f', '\x2', '\xE', '\x2', ' ', 
		'\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '$', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\'', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\a', '\x2', '+', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '.', '\v', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x33', '\n', '\x3', 
		'\f', '\x3', '\xE', '\x3', '\x36', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x5', '\x3', ':', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '\x43', 
		'\n', '\x5', '\f', '\x5', '\xE', '\x5', '\x46', '\v', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x5', '\x6', 'N', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', 'W', '\n', 
		'\a', '\f', '\a', '\xE', '\a', 'Z', '\v', '\a', '\x5', '\a', '\\', '\n', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 
		'\x62', '\n', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\x66', '\n', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\a', '\t', 'n', '\n', '\t', '\f', '\t', '\xE', '\t', 'q', 
		'\v', '\t', '\x3', '\t', '\x5', '\t', 't', '\n', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\a', '\t', 
		'|', '\n', '\t', '\f', '\t', '\xE', '\t', '\x7F', '\v', '\t', '\x3', '\t', 
		'\x5', '\t', '\x82', '\n', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', '\t', '\x8B', 
		'\n', '\t', '\x3', '\t', '\x5', '\t', '\x8E', '\n', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x5', '\f', '\xA3', '\n', '\f', '\x3', '\f', '\x3', 
		'\f', '\x5', '\f', '\xA7', '\n', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x5', '\f', '\xAD', '\n', '\f', '\x3', '\f', '\x3', 
		'\f', '\x5', '\f', '\xB1', '\n', '\f', '\x3', '\f', '\x2', '\x2', '\r', 
		'\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', 
		'\x16', '\x2', '\x2', '\x2', '\xC7', '\x2', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '/', '\x3', '\x2', '\x2', '\x2', '\x6', '=', '\x3', '\x2', 
		'\x2', '\x2', '\b', '?', '\x3', '\x2', '\x2', '\x2', '\n', 'M', '\x3', 
		'\x2', '\x2', '\x2', '\f', 'O', '\x3', '\x2', '\x2', '\x2', '\xE', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x8D', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x14', '\x91', '\x3', '\x2', 
		'\x2', '\x2', '\x16', '\xB0', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', 
		'\a', '\x3', '\x2', '\x2', '\x19', '\x1A', '\a', '#', '\x2', '\x2', '\x1A', 
		'\x1E', '\a', '\x4', '\x2', '\x2', '\x1B', '\x1D', '\x5', '\x4', '\x3', 
		'\x2', '\x1C', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x1F', '!', '\x3', '\x2', '\x2', 
		'\x2', ' ', '\x1E', '\x3', '\x2', '\x2', '\x2', '!', '%', '\a', '\x5', 
		'\x2', '\x2', '\"', '$', '\x5', '\b', '\x5', '\x2', '#', '\"', '\x3', 
		'\x2', '\x2', '\x2', '$', '\'', '\x3', '\x2', '\x2', '\x2', '%', '#', 
		'\x3', '\x2', '\x2', '\x2', '%', '&', '\x3', '\x2', '\x2', '\x2', '&', 
		'(', '\x3', '\x2', '\x2', '\x2', '\'', '%', '\x3', '\x2', '\x2', '\x2', 
		'(', ',', '\a', '\x6', '\x2', '\x2', ')', '+', '\x5', '\f', '\a', '\x2', 
		'*', ')', '\x3', '\x2', '\x2', '\x2', '+', '.', '\x3', '\x2', '\x2', '\x2', 
		',', '*', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', '\x2', '\x2', 
		'-', '\x3', '\x3', '\x2', '\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', 
		'\x2', '/', '\x34', '\a', '#', '\x2', '\x2', '\x30', '\x31', '\a', '\a', 
		'\x2', '\x2', '\x31', '\x33', '\a', '#', '\x2', '\x2', '\x32', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x32', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x39', '\x3', '\x2', '\x2', '\x2', '\x36', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', '\b', '\x2', '\x2', 
		'\x38', ':', '\x5', '\x6', '\x4', '\x2', '\x39', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', '\x2', ':', ';', '\x3', 
		'\x2', '\x2', '\x2', ';', '<', '\a', '\t', '\x2', '\x2', '<', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '=', '>', '\a', '#', '\x2', '\x2', '>', '\a', '\x3', 
		'\x2', '\x2', '\x2', '?', '\x44', '\x5', '\n', '\x6', '\x2', '@', '\x41', 
		'\a', '\a', '\x2', '\x2', '\x41', '\x43', '\x5', '\n', '\x6', '\x2', '\x42', 
		'@', '\x3', '\x2', '\x2', '\x2', '\x43', '\x46', '\x3', '\x2', '\x2', 
		'\x2', '\x44', '\x42', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x45', 'G', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'\x44', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', '\n', '\x2', '\x2', 
		'H', 'I', '\a', '#', '\x2', '\x2', 'I', '\t', '\x3', '\x2', '\x2', '\x2', 
		'J', 'N', '\a', '$', '\x2', '\x2', 'K', 'N', '\a', '\v', '\x2', '\x2', 
		'L', 'N', '\a', '\f', '\x2', '\x2', 'M', 'J', '\x3', '\x2', '\x2', '\x2', 
		'M', 'K', '\x3', '\x2', '\x2', '\x2', 'M', 'L', '\x3', '\x2', '\x2', '\x2', 
		'N', '\v', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\x5', '\xE', '\b', '\x2', 
		'P', 'Q', '\a', '\r', '\x2', '\x2', 'Q', '[', '\x5', '\x10', '\t', '\x2', 
		'R', 'S', '\a', '\xE', '\x2', '\x2', 'S', 'X', '\x5', '\x14', '\v', '\x2', 
		'T', 'U', '\a', '\a', '\x2', '\x2', 'U', 'W', '\x5', '\x14', '\v', '\x2', 
		'V', 'T', '\x3', '\x2', '\x2', '\x2', 'W', 'Z', '\x3', '\x2', '\x2', '\x2', 
		'X', 'V', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\x3', '\x2', '\x2', '\x2', 
		'Y', '\\', '\x3', '\x2', '\x2', '\x2', 'Z', 'X', '\x3', '\x2', '\x2', 
		'\x2', '[', 'R', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\x3', '\x2', 
		'\x2', '\x2', '\\', '\r', '\x3', '\x2', '\x2', '\x2', ']', '\x62', '\a', 
		'$', '\x2', '\x2', '^', '\x62', '\a', '\xF', '\x2', '\x2', '_', '\x62', 
		'\a', '\x10', '\x2', '\x2', '`', '\x62', '\a', '#', '\x2', '\x2', '\x61', 
		']', '\x3', '\x2', '\x2', '\x2', '\x61', '^', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '_', '\x3', '\x2', '\x2', '\x2', '\x61', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x65', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', 
		'\x11', '\x2', '\x2', '\x64', '\x66', '\a', '#', '\x2', '\x2', '\x65', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\x3', '\x2', '\x2', 
		'\x2', '\x66', '\xF', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', '\x12', 
		'\x2', '\x2', 'h', 's', '\x5', '\x12', '\n', '\x2', 'i', 'j', '\a', '\x13', 
		'\x2', '\x2', 'j', 'o', '\a', '#', '\x2', '\x2', 'k', 'l', '\a', '\a', 
		'\x2', '\x2', 'l', 'n', '\a', '#', '\x2', '\x2', 'm', 'k', '\x3', '\x2', 
		'\x2', '\x2', 'n', 'q', '\x3', '\x2', '\x2', '\x2', 'o', 'm', '\x3', '\x2', 
		'\x2', '\x2', 'o', 'p', '\x3', '\x2', '\x2', '\x2', 'p', 'r', '\x3', '\x2', 
		'\x2', '\x2', 'q', 'o', '\x3', '\x2', '\x2', '\x2', 'r', 't', '\a', '\x14', 
		'\x2', '\x2', 's', 'i', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', '\x2', 
		'\x2', '\x2', 't', '\x8E', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', 
		'\x15', '\x2', '\x2', 'v', '\x81', '\x5', '\x12', '\n', '\x2', 'w', 'x', 
		'\a', '\x13', '\x2', '\x2', 'x', '}', '\a', '#', '\x2', '\x2', 'y', 'z', 
		'\a', '\a', '\x2', '\x2', 'z', '|', '\a', '#', '\x2', '\x2', '{', 'y', 
		'\x3', '\x2', '\x2', '\x2', '|', '\x7F', '\x3', '\x2', '\x2', '\x2', '}', 
		'{', '\x3', '\x2', '\x2', '\x2', '}', '~', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x80', '\x3', '\x2', '\x2', '\x2', '\x7F', '}', '\x3', '\x2', '\x2', 
		'\x2', '\x80', '\x82', '\a', '\x14', '\x2', '\x2', '\x81', 'w', '\x3', 
		'\x2', '\x2', '\x2', '\x81', '\x82', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x8E', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\a', '\x16', '\x2', 
		'\x2', '\x84', '\x8E', '\a', '#', '\x2', '\x2', '\x85', '\x86', '\a', 
		'\x17', '\x2', '\x2', '\x86', '\x8E', '\a', '#', '\x2', '\x2', '\x87', 
		'\x88', '\a', '\x18', '\x2', '\x2', '\x88', '\x8A', '\a', '#', '\x2', 
		'\x2', '\x89', '\x8B', '\a', '\x19', '\x2', '\x2', '\x8A', '\x89', '\x3', 
		'\x2', '\x2', '\x2', '\x8A', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8E', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8E', '\a', '\x1A', '\x2', 
		'\x2', '\x8D', 'g', '\x3', '\x2', '\x2', '\x2', '\x8D', 'u', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x83', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x85', 
		'\x3', '\x2', '\x2', '\x2', '\x8D', '\x87', '\x3', '\x2', '\x2', '\x2', 
		'\x8D', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x90', '\a', '#', '\x2', '\x2', '\x90', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x91', '\x92', '\a', '#', '\x2', '\x2', '\x92', 
		'\x93', '\a', '\x1B', '\x2', '\x2', '\x93', '\x94', '\x5', '\x16', '\f', 
		'\x2', '\x94', '\x15', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\a', 
		'\x1C', '\x2', '\x2', '\x96', '\xB1', '\a', '#', '\x2', '\x2', '\x97', 
		'\x98', '\a', '\x1D', '\x2', '\x2', '\x98', '\xB1', '\a', '#', '\x2', 
		'\x2', '\x99', '\x9A', '\a', '\x1E', '\x2', '\x2', '\x9A', '\xB1', '\a', 
		'#', '\x2', '\x2', '\x9B', '\xA2', '\a', '\x1F', '\x2', '\x2', '\x9C', 
		'\xA3', '\a', '#', '\x2', '\x2', '\x9D', '\x9E', '\a', '\x13', '\x2', 
		'\x2', '\x9E', '\x9F', '\a', '#', '\x2', '\x2', '\x9F', '\xA0', '\a', 
		'\x11', '\x2', '\x2', '\xA0', '\xA1', '\a', '#', '\x2', '\x2', '\xA1', 
		'\xA3', '\a', '\x14', '\x2', '\x2', '\xA2', '\x9C', '\x3', '\x2', '\x2', 
		'\x2', '\xA2', '\x9D', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA6', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA5', '\a', ' ', '\x2', '\x2', '\xA5', 
		'\xA7', '\a', '#', '\x2', '\x2', '\xA6', '\xA4', '\x3', '\x2', '\x2', 
		'\x2', '\xA6', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xB1', '\x3', 
		'\x2', '\x2', '\x2', '\xA8', '\xA9', '\a', '!', '\x2', '\x2', '\xA9', 
		'\xAC', '\a', '#', '\x2', '\x2', '\xAA', '\xAB', '\a', ' ', '\x2', '\x2', 
		'\xAB', '\xAD', '\a', '#', '\x2', '\x2', '\xAC', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\xAC', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xB1', 
		'\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\a', '\"', '\x2', '\x2', 
		'\xAF', '\xB1', '\a', '#', '\x2', '\x2', '\xB0', '\x95', '\x3', '\x2', 
		'\x2', '\x2', '\xB0', '\x97', '\x3', '\x2', '\x2', '\x2', '\xB0', '\x99', 
		'\x3', '\x2', '\x2', '\x2', '\xB0', '\x9B', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xAE', '\x3', '\x2', 
		'\x2', '\x2', '\xB1', '\x17', '\x3', '\x2', '\x2', '\x2', '\x17', '\x1E', 
		'%', ',', '\x34', '\x39', '\x44', 'M', 'X', '[', '\x61', '\x65', 'o', 
		's', '}', '\x81', '\x8A', '\x8D', '\xA2', '\xA6', '\xAC', '\xB0',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Engage.parsing
