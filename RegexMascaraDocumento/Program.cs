using System.Text.RegularExpressions;

var cpf = "123.456.789-00";
Console.WriteLine($"Documento sem a máscara: {cpf}");

var regex = new Regex(@"^(\d{2,3})\.\d{3}\.\d{3}\-(\d{2})");
var cpfMask = regex.Replace(cpf, "$1.***.***-$2");

Console.WriteLine($"Documento com a máscara: {cpfMask}");
