//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/julia/RiderProjects/RaccoonDB/RaccoonDB\RaccoonSQL.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class RaccoonSQLLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, Identifier=26, LINE_COMMENT=27, WS=28;
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
		"Identifier", "LINE_COMMENT", "WS"
	};


	public RaccoonSQLLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RaccoonSQLLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'create'", "'drop'", "'alter'", "'explain'", "'truncate'", "'('", 
		"')'", "'index'", "'on'", "'table'", "','", "'auto'", "'not'", "'null'", 
		"'unique'", "'primary'", "'key'", "'foreign'", "'references'", "'add'", 
		"'select'", "'update'", "'delete'", "'insert'", "'into'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "Identifier", "LINE_COMMENT", "WS"
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

	public override string GrammarFileName { get { return "RaccoonSQL.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RaccoonSQLLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1E', '\xE3', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		'\x1D', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', 
		'\a', '\x1B', '\xCF', '\n', '\x1B', '\f', '\x1B', '\xE', '\x1B', '\xD2', 
		'\v', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xD6', '\n', 
		'\x1C', '\f', '\x1C', '\xE', '\x1C', '\xD9', '\v', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1D', '\x6', '\x1D', '\xDE', '\n', '\x1D', '\r', 
		'\x1D', '\xE', '\x1D', '\xDF', '\x3', '\x1D', '\x3', '\x1D', '\x2', '\x2', 
		'\x1E', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x1E', '\x3', '\x2', '\x6', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\a', '\x2', '/', '/', '\x32', ';', '\x43', '\\', '\x61', 
		'\x61', '\x63', '|', '\x3', '\x2', '\f', '\f', '\x5', '\x2', '\v', '\f', 
		'\xE', '\xF', '\"', '\"', '\x2', '\xE5', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x3', ';', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x42', '\x3', '\x2', '\x2', '\x2', '\a', 'G', '\x3', '\x2', '\x2', 
		'\x2', '\t', 'M', '\x3', '\x2', '\x2', '\x2', '\v', 'U', '\x3', '\x2', 
		'\x2', '\x2', '\r', '^', '\x3', '\x2', '\x2', '\x2', '\xF', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x62', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'h', '\x3', '\x2', '\x2', '\x2', '\x15', 'k', '\x3', '\x2', '\x2', '\x2', 
		'\x17', 'q', '\x3', '\x2', '\x2', '\x2', '\x19', 's', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', 'x', '\x3', '\x2', '\x2', '\x2', '\x1D', '|', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '\x81', '\x3', '\x2', '\x2', '\x2', '!', '\x88', 
		'\x3', '\x2', '\x2', '\x2', '#', '\x90', '\x3', '\x2', '\x2', '\x2', '%', 
		'\x94', '\x3', '\x2', '\x2', '\x2', '\'', '\x9C', '\x3', '\x2', '\x2', 
		'\x2', ')', '\xA7', '\x3', '\x2', '\x2', '\x2', '+', '\xAB', '\x3', '\x2', 
		'\x2', '\x2', '-', '\xB2', '\x3', '\x2', '\x2', '\x2', '/', '\xB9', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\xC0', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\xC7', '\x3', '\x2', '\x2', '\x2', '\x35', '\xCC', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\xD3', '\x3', '\x2', '\x2', '\x2', '\x39', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', ';', '<', '\a', '\x65', '\x2', '\x2', '<', '=', '\a', 
		't', '\x2', '\x2', '=', '>', '\a', 'g', '\x2', '\x2', '>', '?', '\a', 
		'\x63', '\x2', '\x2', '?', '@', '\a', 'v', '\x2', '\x2', '@', '\x41', 
		'\a', 'g', '\x2', '\x2', '\x41', '\x4', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x43', '\a', '\x66', '\x2', '\x2', '\x43', '\x44', '\a', 't', '\x2', 
		'\x2', '\x44', '\x45', '\a', 'q', '\x2', '\x2', '\x45', '\x46', '\a', 
		'r', '\x2', '\x2', '\x46', '\x6', '\x3', '\x2', '\x2', '\x2', 'G', 'H', 
		'\a', '\x63', '\x2', '\x2', 'H', 'I', '\a', 'n', '\x2', '\x2', 'I', 'J', 
		'\a', 'v', '\x2', '\x2', 'J', 'K', '\a', 'g', '\x2', '\x2', 'K', 'L', 
		'\a', 't', '\x2', '\x2', 'L', '\b', '\x3', '\x2', '\x2', '\x2', 'M', 'N', 
		'\a', 'g', '\x2', '\x2', 'N', 'O', '\a', 'z', '\x2', '\x2', 'O', 'P', 
		'\a', 'r', '\x2', '\x2', 'P', 'Q', '\a', 'n', '\x2', '\x2', 'Q', 'R', 
		'\a', '\x63', '\x2', '\x2', 'R', 'S', '\a', 'k', '\x2', '\x2', 'S', 'T', 
		'\a', 'p', '\x2', '\x2', 'T', '\n', '\x3', '\x2', '\x2', '\x2', 'U', 'V', 
		'\a', 'v', '\x2', '\x2', 'V', 'W', '\a', 't', '\x2', '\x2', 'W', 'X', 
		'\a', 'w', '\x2', '\x2', 'X', 'Y', '\a', 'p', '\x2', '\x2', 'Y', 'Z', 
		'\a', '\x65', '\x2', '\x2', 'Z', '[', '\a', '\x63', '\x2', '\x2', '[', 
		'\\', '\a', 'v', '\x2', '\x2', '\\', ']', '\a', 'g', '\x2', '\x2', ']', 
		'\f', '\x3', '\x2', '\x2', '\x2', '^', '_', '\a', '*', '\x2', '\x2', '_', 
		'\xE', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\a', '+', '\x2', '\x2', 
		'\x61', '\x10', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', 'k', 
		'\x2', '\x2', '\x63', '\x64', '\a', 'p', '\x2', '\x2', '\x64', '\x65', 
		'\a', '\x66', '\x2', '\x2', '\x65', '\x66', '\a', 'g', '\x2', '\x2', '\x66', 
		'g', '\a', 'z', '\x2', '\x2', 'g', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'h', 'i', '\a', 'q', '\x2', '\x2', 'i', 'j', '\a', 'p', '\x2', '\x2', 
		'j', '\x14', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', 'v', '\x2', '\x2', 
		'l', 'm', '\a', '\x63', '\x2', '\x2', 'm', 'n', '\a', '\x64', '\x2', '\x2', 
		'n', 'o', '\a', 'n', '\x2', '\x2', 'o', 'p', '\a', 'g', '\x2', '\x2', 
		'p', '\x16', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\a', '.', '\x2', '\x2', 
		'r', '\x18', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', '\x63', '\x2', 
		'\x2', 't', 'u', '\a', 'w', '\x2', '\x2', 'u', 'v', '\a', 'v', '\x2', 
		'\x2', 'v', 'w', '\a', 'q', '\x2', '\x2', 'w', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'x', 'y', '\a', 'p', '\x2', '\x2', 'y', 'z', '\a', 'q', '\x2', 
		'\x2', 'z', '{', '\a', 'v', '\x2', '\x2', '{', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '|', '}', '\a', 'p', '\x2', '\x2', '}', '~', '\a', 'w', '\x2', 
		'\x2', '~', '\x7F', '\a', 'n', '\x2', '\x2', '\x7F', '\x80', '\a', 'n', 
		'\x2', '\x2', '\x80', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', 
		'\a', 'w', '\x2', '\x2', '\x82', '\x83', '\a', 'p', '\x2', '\x2', '\x83', 
		'\x84', '\a', 'k', '\x2', '\x2', '\x84', '\x85', '\a', 's', '\x2', '\x2', 
		'\x85', '\x86', '\a', 'w', '\x2', '\x2', '\x86', '\x87', '\a', 'g', '\x2', 
		'\x2', '\x87', ' ', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\a', 
		'r', '\x2', '\x2', '\x89', '\x8A', '\a', 't', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'k', '\x2', '\x2', '\x8B', '\x8C', '\a', 'o', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', '\x63', '\x2', '\x2', '\x8D', '\x8E', '\a', 't', '\x2', 
		'\x2', '\x8E', '\x8F', '\a', '{', '\x2', '\x2', '\x8F', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x90', '\x91', '\a', 'm', '\x2', '\x2', '\x91', '\x92', 
		'\a', 'g', '\x2', '\x2', '\x92', '\x93', '\a', '{', '\x2', '\x2', '\x93', 
		'$', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'h', '\x2', '\x2', 
		'\x95', '\x96', '\a', 'q', '\x2', '\x2', '\x96', '\x97', '\a', 't', '\x2', 
		'\x2', '\x97', '\x98', '\a', 'g', '\x2', '\x2', '\x98', '\x99', '\a', 
		'k', '\x2', '\x2', '\x99', '\x9A', '\a', 'i', '\x2', '\x2', '\x9A', '\x9B', 
		'\a', 'p', '\x2', '\x2', '\x9B', '&', '\x3', '\x2', '\x2', '\x2', '\x9C', 
		'\x9D', '\a', 't', '\x2', '\x2', '\x9D', '\x9E', '\a', 'g', '\x2', '\x2', 
		'\x9E', '\x9F', '\a', 'h', '\x2', '\x2', '\x9F', '\xA0', '\a', 'g', '\x2', 
		'\x2', '\xA0', '\xA1', '\a', 't', '\x2', '\x2', '\xA1', '\xA2', '\a', 
		'g', '\x2', '\x2', '\xA2', '\xA3', '\a', 'p', '\x2', '\x2', '\xA3', '\xA4', 
		'\a', '\x65', '\x2', '\x2', '\xA4', '\xA5', '\a', 'g', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', 'u', '\x2', '\x2', '\xA6', '(', '\x3', '\x2', '\x2', '\x2', 
		'\xA7', '\xA8', '\a', '\x63', '\x2', '\x2', '\xA8', '\xA9', '\a', '\x66', 
		'\x2', '\x2', '\xA9', '\xAA', '\a', '\x66', '\x2', '\x2', '\xAA', '*', 
		'\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', 'u', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'g', '\x2', '\x2', '\xAD', '\xAE', '\a', 'n', '\x2', '\x2', 
		'\xAE', '\xAF', '\a', 'g', '\x2', '\x2', '\xAF', '\xB0', '\a', '\x65', 
		'\x2', '\x2', '\xB0', '\xB1', '\a', 'v', '\x2', '\x2', '\xB1', ',', '\x3', 
		'\x2', '\x2', '\x2', '\xB2', '\xB3', '\a', 'w', '\x2', '\x2', '\xB3', 
		'\xB4', '\a', 'r', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x66', '\x2', 
		'\x2', '\xB5', '\xB6', '\a', '\x63', '\x2', '\x2', '\xB6', '\xB7', '\a', 
		'v', '\x2', '\x2', '\xB7', '\xB8', '\a', 'g', '\x2', '\x2', '\xB8', '.', 
		'\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\a', '\x66', '\x2', '\x2', 
		'\xBA', '\xBB', '\a', 'g', '\x2', '\x2', '\xBB', '\xBC', '\a', 'n', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', 'g', '\x2', '\x2', '\xBD', '\xBE', '\a', 
		'v', '\x2', '\x2', '\xBE', '\xBF', '\a', 'g', '\x2', '\x2', '\xBF', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\a', 'k', '\x2', '\x2', '\xC1', 
		'\xC2', '\a', 'p', '\x2', '\x2', '\xC2', '\xC3', '\a', 'u', '\x2', '\x2', 
		'\xC3', '\xC4', '\a', 'g', '\x2', '\x2', '\xC4', '\xC5', '\a', 't', '\x2', 
		'\x2', '\xC5', '\xC6', '\a', 'v', '\x2', '\x2', '\xC6', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', 'k', '\x2', '\x2', '\xC8', 
		'\xC9', '\a', 'p', '\x2', '\x2', '\xC9', '\xCA', '\a', 'v', '\x2', '\x2', 
		'\xCA', '\xCB', '\a', 'q', '\x2', '\x2', '\xCB', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\xCC', '\xD0', '\t', '\x2', '\x2', '\x2', '\xCD', '\xCF', 
		'\t', '\x3', '\x2', '\x2', '\xCE', '\xCD', '\x3', '\x2', '\x2', '\x2', 
		'\xCF', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xCE', '\x3', '\x2', 
		'\x2', '\x2', '\xD0', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD1', '\x36', 
		'\x3', '\x2', '\x2', '\x2', '\xD2', '\xD0', '\x3', '\x2', '\x2', '\x2', 
		'\xD3', '\xD7', '\a', '=', '\x2', '\x2', '\xD4', '\xD6', '\n', '\x4', 
		'\x2', '\x2', '\xD5', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD9', 
		'\x3', '\x2', '\x2', '\x2', '\xD7', '\xD5', '\x3', '\x2', '\x2', '\x2', 
		'\xD7', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xDA', '\x3', '\x2', 
		'\x2', '\x2', '\xD9', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDB', 
		'\b', '\x1C', '\x2', '\x2', '\xDB', '\x38', '\x3', '\x2', '\x2', '\x2', 
		'\xDC', '\xDE', '\t', '\x5', '\x2', '\x2', '\xDD', '\xDC', '\x3', '\x2', 
		'\x2', '\x2', '\xDE', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xDF', '\xDD', 
		'\x3', '\x2', '\x2', '\x2', '\xDF', '\xE0', '\x3', '\x2', '\x2', '\x2', 
		'\xE0', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\b', '\x1D', 
		'\x2', '\x2', '\xE2', ':', '\x3', '\x2', '\x2', '\x2', '\x6', '\x2', '\xD0', 
		'\xD7', '\xDF', '\x3', '\x2', '\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
