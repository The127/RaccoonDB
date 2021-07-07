using System;
using RaccoonDB.Interface;

var raccoonDbDriver = new RaccoonDbDriver("C:\\Users\\julia\\raccoonDb");
raccoonDbDriver.ExecuteSql(@"
    create table tickets if not exists (
        Id uuid auto primary key, 
        Name string not null,
        description string
    );
");

var explainColumnsResult = raccoonDbDriver.ExecuteSql("explain table tickets;");
Console.WriteLine(explainColumnsResult);

var explainIndicesResult = raccoonDbDriver.ExecuteSql("explain indices on table tickets;");
Console.WriteLine(explainIndicesResult);

raccoonDbDriver.ExecuteSql("drop table tickets if exists;");
