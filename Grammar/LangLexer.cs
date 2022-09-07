//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\flavi\OneDrive\Documentos\Meus_Projetos\Interpretador\Lang.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class LangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		OE=1, CE=2, OB=3, CB=4, AT=5, PLUS=6, MINUS=7, MULT=8, DIV=9, AND=10, 
		OR=11, NOT=12, EQ=13, LT=14, GT=15, LE=16, GE=17, NE=18, BOOL_TRUE=19, 
		BOOL_FALSE=20, IF=21, ELSE=22, WRITE=23, READ=24, WHILE=25, STR=26, EOL=27, 
		NUM=28, VAR=29, COMMENT=30, WS=31;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"OE", "CE", "OB", "CB", "AT", "PLUS", "MINUS", "MULT", "DIV", "AND", "OR", 
		"NOT", "EQ", "LT", "GT", "LE", "GE", "NE", "BOOL_TRUE", "BOOL_FALSE", 
		"IF", "ELSE", "WRITE", "READ", "WHILE", "STR", "EOL", "NUM", "VAR", "COMMENT", 
		"WS"
	};


	public LangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'{'", "'}'", "'='", "'+'", "'-'", "'*'", "'/'", "'&&'", 
		"'||'", "'!'", "'=='", "'<'", "'>'", "'<='", "'>='", "'!='", "'true'", 
		"'false'", "'IF'", "'ELSE'", "'WRITE'", "'READ'", "'WHILE'", null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "OE", "CE", "OB", "CB", "AT", "PLUS", "MINUS", "MULT", "DIV", "AND", 
		"OR", "NOT", "EQ", "LT", "GT", "LE", "GE", "NE", "BOOL_TRUE", "BOOL_FALSE", 
		"IF", "ELSE", "WRITE", "READ", "WHILE", "STR", "EOL", "NUM", "VAR", "COMMENT", 
		"WS"
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

	public override string GrammarFileName { get { return "Lang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '!', '\xBE', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		' ', '\t', ' ', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\a', '\x1B', 
		'\x92', '\n', '\x1B', '\f', '\x1B', '\xE', '\x1B', '\x95', '\v', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', 
		'\x6', '\x1D', '\x9C', '\n', '\x1D', '\r', '\x1D', '\xE', '\x1D', '\x9D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x6', '\x1D', '\xA2', '\n', '\x1D', '\r', 
		'\x1D', '\xE', '\x1D', '\xA3', '\x5', '\x1D', '\xA6', '\n', '\x1D', '\x3', 
		'\x1E', '\x6', '\x1E', '\xA9', '\n', '\x1E', '\r', '\x1E', '\xE', '\x1E', 
		'\xAA', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\a', 
		'\x1F', '\xB1', '\n', '\x1F', '\f', '\x1F', '\xE', '\x1F', '\xB4', '\v', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x6', ' ', '\xB9', 
		'\n', ' ', '\r', ' ', '\xE', ' ', '\xBA', '\x3', ' ', '\x3', ' ', '\x2', 
		'\x2', '!', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', 
		'\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', 
		'\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', 
		'\x3', '\x2', '\a', '\x3', '\x2', '$', '$', '\x3', '\x2', '\x32', ';', 
		'\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xC4', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x3', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '\x43', '\x3', '\x2', '\x2', '\x2', '\a', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\t', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\v', 'I', '\x3', '\x2', '\x2', '\x2', '\r', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\xF', 'M', '\x3', '\x2', '\x2', '\x2', '\x11', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\x13', 'Q', '\x3', '\x2', '\x2', '\x2', '\x15', 'S', '\x3', 
		'\x2', '\x2', '\x2', '\x17', 'V', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'Y', '\x3', '\x2', '\x2', '\x2', '\x1B', '[', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '^', '\x3', '\x2', '\x2', '\x2', '\x1F', '`', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x62', '\x3', '\x2', '\x2', '\x2', '#', '\x65', '\x3', '\x2', 
		'\x2', '\x2', '%', 'h', '\x3', '\x2', '\x2', '\x2', '\'', 'k', '\x3', 
		'\x2', '\x2', '\x2', ')', 'p', '\x3', '\x2', '\x2', '\x2', '+', 'v', '\x3', 
		'\x2', '\x2', '\x2', '-', 'y', '\x3', '\x2', '\x2', '\x2', '/', '~', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\x84', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x89', '\x3', '\x2', '\x2', '\x2', '\x35', '\x8F', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x98', '\x3', '\x2', '\x2', '\x2', '\x39', '\x9B', '\x3', 
		'\x2', '\x2', '\x2', ';', '\xA8', '\x3', '\x2', '\x2', '\x2', '=', '\xAC', 
		'\x3', '\x2', '\x2', '\x2', '?', '\xB8', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\x42', '\a', '*', '\x2', '\x2', '\x42', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '\x44', '\a', '+', '\x2', '\x2', '\x44', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x46', '\a', '}', '\x2', '\x2', '\x46', '\b', '\x3', 
		'\x2', '\x2', '\x2', 'G', 'H', '\a', '\x7F', '\x2', '\x2', 'H', '\n', 
		'\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', '?', '\x2', '\x2', 'J', '\f', 
		'\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', '-', '\x2', '\x2', 'L', '\xE', 
		'\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', '/', '\x2', '\x2', 'N', '\x10', 
		'\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', ',', '\x2', '\x2', 'P', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', '\x31', '\x2', '\x2', 'R', 
		'\x14', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\a', '(', '\x2', '\x2', 
		'T', 'U', '\a', '(', '\x2', '\x2', 'U', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'V', 'W', '\a', '~', '\x2', '\x2', 'W', 'X', '\a', '~', '\x2', '\x2', 
		'X', '\x18', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\a', '#', '\x2', '\x2', 
		'Z', '\x1A', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', '?', '\x2', 
		'\x2', '\\', ']', '\a', '?', '\x2', '\x2', ']', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '^', '_', '\a', '>', '\x2', '\x2', '_', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x61', '\a', '@', '\x2', '\x2', '\x61', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x62', '\x63', '\a', '>', '\x2', '\x2', '\x63', 
		'\x64', '\a', '?', '\x2', '\x2', '\x64', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\x65', '\x66', '\a', '@', '\x2', '\x2', '\x66', 'g', '\a', '?', '\x2', 
		'\x2', 'g', '$', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', '#', '\x2', 
		'\x2', 'i', 'j', '\a', '?', '\x2', '\x2', 'j', '&', '\x3', '\x2', '\x2', 
		'\x2', 'k', 'l', '\a', 'v', '\x2', '\x2', 'l', 'm', '\a', 't', '\x2', 
		'\x2', 'm', 'n', '\a', 'w', '\x2', '\x2', 'n', 'o', '\a', 'g', '\x2', 
		'\x2', 'o', '(', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'h', '\x2', 
		'\x2', 'q', 'r', '\a', '\x63', '\x2', '\x2', 'r', 's', '\a', 'n', '\x2', 
		'\x2', 's', 't', '\a', 'u', '\x2', '\x2', 't', 'u', '\a', 'g', '\x2', 
		'\x2', 'u', '*', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', 'K', '\x2', 
		'\x2', 'w', 'x', '\a', 'H', '\x2', '\x2', 'x', ',', '\x3', '\x2', '\x2', 
		'\x2', 'y', 'z', '\a', 'G', '\x2', '\x2', 'z', '{', '\a', 'N', '\x2', 
		'\x2', '{', '|', '\a', 'U', '\x2', '\x2', '|', '}', '\a', 'G', '\x2', 
		'\x2', '}', '.', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\a', 'Y', '\x2', 
		'\x2', '\x7F', '\x80', '\a', 'T', '\x2', '\x2', '\x80', '\x81', '\a', 
		'K', '\x2', '\x2', '\x81', '\x82', '\a', 'V', '\x2', '\x2', '\x82', '\x83', 
		'\a', 'G', '\x2', '\x2', '\x83', '\x30', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'T', '\x2', '\x2', '\x85', '\x86', '\a', 'G', '\x2', '\x2', 
		'\x86', '\x87', '\a', '\x43', '\x2', '\x2', '\x87', '\x88', '\a', '\x46', 
		'\x2', '\x2', '\x88', '\x32', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 'Y', '\x2', '\x2', '\x8A', '\x8B', '\a', 'J', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', 'K', '\x2', '\x2', '\x8C', '\x8D', '\a', 'N', '\x2', '\x2', 
		'\x8D', '\x8E', '\a', 'G', '\x2', '\x2', '\x8E', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x93', '\a', '$', '\x2', '\x2', '\x90', '\x92', 
		'\n', '\x2', '\x2', '\x2', '\x91', '\x90', '\x3', '\x2', '\x2', '\x2', 
		'\x92', '\x95', '\x3', '\x2', '\x2', '\x2', '\x93', '\x91', '\x3', '\x2', 
		'\x2', '\x2', '\x93', '\x94', '\x3', '\x2', '\x2', '\x2', '\x94', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '\x95', '\x93', '\x3', '\x2', '\x2', '\x2', 
		'\x96', '\x97', '\a', '$', '\x2', '\x2', '\x97', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x98', '\x99', '\a', '=', '\x2', '\x2', '\x99', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x9A', '\x9C', '\t', '\x3', '\x2', '\x2', 
		'\x9B', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', 
		'\x2', '\x2', '\x9D', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\xA5', '\x3', '\x2', '\x2', '\x2', 
		'\x9F', '\xA1', '\v', '\x2', '\x2', '\x2', '\xA0', '\xA2', '\t', '\x3', 
		'\x2', '\x2', '\xA1', '\xA0', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\x3', '\x2', '\x2', '\x2', '\xA3', '\xA1', '\x3', '\x2', '\x2', '\x2', 
		'\xA3', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA6', '\x3', '\x2', 
		'\x2', '\x2', '\xA5', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', 
		'\x3', '\x2', '\x2', '\x2', '\xA6', ':', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xA9', '\t', '\x4', '\x2', '\x2', '\xA8', '\xA7', '\x3', '\x2', '\x2', 
		'\x2', '\xA9', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xA8', '\x3', 
		'\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xAB', 
		'<', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAD', '\a', '\x31', '\x2', 
		'\x2', '\xAD', '\xAE', '\a', '\x31', '\x2', '\x2', '\xAE', '\xB2', '\x3', 
		'\x2', '\x2', '\x2', '\xAF', '\xB1', '\n', '\x5', '\x2', '\x2', '\xB0', 
		'\xAF', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB4', '\x3', '\x2', '\x2', 
		'\x2', '\xB2', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\x3', 
		'\x2', '\x2', '\x2', '\xB3', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB4', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\b', '\x1F', '\x2', 
		'\x2', '\xB6', '>', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB9', '\t', 
		'\x6', '\x2', '\x2', '\xB8', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB9', 
		'\xBA', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xB8', '\x3', '\x2', '\x2', 
		'\x2', '\xBA', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', '\x3', 
		'\x2', '\x2', '\x2', '\xBC', '\xBD', '\b', ' ', '\x2', '\x2', '\xBD', 
		'@', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\x93', '\x9D', '\xA3', 
		'\xA5', '\xAA', '\xB2', '\xBA', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar