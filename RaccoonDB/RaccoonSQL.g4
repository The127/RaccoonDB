grammar RaccoonSQL;

query
    : (createQuery | dropQuery | alterQuery | explainQuery | truncateQuery | selectQuery | updateQuery | deleteQuery | insertQuery)
    ;
    
    
createQuery
    : 'create' (createIndex | createTable)
    ;

dropQuery
    : 'drop' (index | table)
    ;
    
alterQuery
    : 'alter' table (addColumn | dropColumn | alterColumn)
    ;    
    
explainQuery
    : 'explain' (index | table)
    ;    
    
truncateQuery
    : 'truncate' table
    ;


createIndex
    : uniqueConstraint? index '(' indexColumns ')'
    ;
    
index
    : 'index' indexIdentifier=Identifier 'on' 'table' tableIdentifier=Identifier
    ;    

indexColumns
    : indexColumn (',' indexColumn)*
    ;
    
indexColumn
    : columnName=Identifier
    ;    

    
createTable
    : table '(' tableColumns ')'
    ;    
    
table
    : 'table' tableName=Identifier 
    ;

tableColumns
    : tableColumn (',' tableColumn)*
    ;
    
tableColumn
    : name=Identifier type=Identifier columnConstraint*
    ;    
    
columnConstraint
    : notNullConstraint
    | uniqueConstraint
    | primaryKeyConstraint
    | foreignKeyConstraint
    | autoValue
    ;    
    
autoValue
    : 'auto'
    ;    
    
notNullConstraint
    : 'not' 'null'
    ;

uniqueConstraint
    : 'unique'
    ;    
    
primaryKeyConstraint    
    : 'primary' 'key'
    ;
    
foreignKeyConstraint
    : 'foreign' 'key' 'references' tableName=Identifier '(' columnName=Identifier ')'
    ;
    
addColumn
    : 'add' tableColumn
    ;
    
dropColumn
    : 'drop' columnName=Identifier
    ;
    
alterColumn
    : 'alter' tableColumn
    ;    
    
    
selectQuery
    : 'select'
    ;    
    
updateQuery
    : 'update'
    ;
    
deleteQuery
    : 'delete'
    ;
    
insertQuery
    : 'insert' 'into'
    ;    

// start with letters (upper or lower case) followed by any alphanumeric symbol
Identifier
  :  ('a'..'z' | 'A'..'Z') ('a'..'z' | 'A'..'Z' | '_' | '-' | '0'..'9')*
  ;

LINE_COMMENT
	: ';' ~[\n]* -> channel(HIDDEN)
	;

WS 
	: [ \t\r\n\f]+ -> channel(HIDDEN) 
	;