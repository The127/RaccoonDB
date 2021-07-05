using System;
using RaccoonDB.Interface;

var raccoonDbDriver = new RaccoonDbDriver("db.raccoon");
var result = raccoonDbDriver.ExecuteSql("create table test (foo int, cum string not null unique auto);");
Console.WriteLine(result);