// See https://aka.ms/new-console-template for more information
using GeneratorTool.Examples;
using Newtonsoft.Json;


// use blog or survey model as examples
// put the generated json in try it out page in the portal editor under this link https://victorious-glacier-0ea93880f.5.azurestaticapps.net/ide
// then press sumbit to genrate and download the solution as zip file

var json = JsonConvert.SerializeObject(Blog.SolutionModel);

Console.WriteLine(json);
Console.Read();