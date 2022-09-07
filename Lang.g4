grammar Lang;

prog: functions line+             # progLine
    ;

functions: function functions
        |
        ;
 
function: FUNCTION VAR '('params')' fnBlock;

 
fnBlock:
     '{' fnBody '}'                # fnBlockLine
    ;

fnBody:
      line                      # fnBodyLine
    | line fnBody               # fnBodyLineMore
    | RETURN expr EOL           # fnReturnExprLine
    | RETURN EOL                # fnReturnLine
    ;

params:  
        VAR
      | VAR SEP params
      | // empty
      ;

line:
	  stmt EOL          # lineStmt
	| ifst              # lineIf
	//| whilest         # lineWhile
    //| forst           # lineFor
	| EOL              # lineEOL
    ;

funcInvoc:
    VAR '(' params ')' # funcInvocLine
    ;

stmt: 
      atrib             # stmtAtrib
    | input             # stmtInput
    | output            # stmtOutput    
    | funcInvoc        # lineFuncInvoc
    ;

input:
      READ VAR      # inputRead
    ;

output:
      WRITE VAR     # outputWriteVar
    | WRITE STR     # outputWriteStr
    | WRITE expr    # outputWriteExpr
    ;

ifst:
      IF '(' cond ')' block                     # ifstIf 
    | IF '(' cond ')' b1=block ELSE b2=block    # ifstIfElse
    ;

block:
      '{' line+ '}'     #blockLine
    ;

cond:
      expr                                          #condExpr
    | e1=expr RELOP=(EQ|NE|LT|GT|LE|GE) e2=expr     #condRelop
    | c1=cond AND c2=cond                           #condAnd
    | c1=cond OR c2=cond                            #condOr
    | NOT cond                                      #condNot
    ;

whilest:
      WHILE '(' cond ')' block               #while
    ;

atrib:
      VAR '=' expr          #atribVar
    ;

expr:
      term '+' expr         #exprPlus
    | term '-' expr         #exprMinus
    | term                  #exprTerm
    ;

term:
      factor '*' term       #termMulti
    | factor '/' term       #termDiv
    | factor                #termFactor
    ;

factor:
      '(' expr ')'          #factorExpr
    | VAR                   #factorVar
    | NUM                   #factorNum
    ;


// Regras
OE: '(';
CE: ')';
OB: '{';
CB: '}';
AT: '=';
PLUS: '+';
MINUS: '-';
MULT: '*';
DIV: '/'; 
AND: '&&';
OR: '||';
NOT: '!';
EQ: '==';
LT: '<';
GT: '>';
LE: '<=';
GE: '>=';
NE: '!=';
SEP: ',';
BOOL_TRUE: 'true';
BOOL_FALSE: 'false';
IF: 'IF';
ELSE: 'ELSE';
WRITE: 'WRITE'; 
READ: 'READ';
WHILE: 'WHILE';
FUNCTION: 'FUNCTION';
RETURN: 'RETURN';
STR: '"' ~["]* '"';
EOL: ';';
NUM: [0-9]+ (.([0-9]+))?;
VAR: [a-zA-Z]+;
COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;
