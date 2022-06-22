using Dapper;
using EFBuyers;
using System;
using System.Data;
using System.Data.SqlClient;

IDbConnection conn = new SqlConnection("Data Source=DESKTOP-JDQ2UQC;Initial Catalog=Stocks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); 

//2
try
{
    conn.Open();
}
catch (Exception ex)
{
    Console.WriteLine("Connection false");
}
Console.WriteLine("Connection success");

//3
string query = "select * from Buyer";

var result = conn.Query<Buyer>(query).ToList();

/*foreach (var item in result)
{
    Console.WriteLine(item+"\n");
}
conn.Close();*/

//4

result = conn.Query<Buyer>(ByCity("Sumgayit")).ToList();

foreach (var item in result)
{
    Console.WriteLine(item + "\n");
}
conn.Close();

string ByCountry(string _countryname)
{
    string query = $"select * from Buyer where Country = '{_countryname}'";

    return query;
}

string ByCity(string _cityname)
{
    string query = $"select * from Buyer where City = '{_cityname}'";

    return query;
}

string BySection(string _section)
{
    string query = $"select * from Buyer where Section = '{_section}'";

    return query;
}

