using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using MagazynNarzedziowy.Domain.Entity;
using System.Linq;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using MagazynNarzedziowy.App.Common;

namespace MagazynNarzedziowy.App.Concrete
{
    public class ListService : BaseService<Tools>
    {
        //public ListService()
        //{
        //    //List<Tools> tools = new List<Tools>();
        //    var lines = File.ReadAllLines(@"/Users/maciejfaltynski/Documents/proba.json");
        //    string json = string.Join("", lines);
        //    var tools = JsonConvert.DeserializeObject<List<Tools>>(json);
        //        foreach (var x in tools)
        //        {
        //            Objects.Add(x);
        //        }
            


        //}
    }
}
        

  





//string path= "/Users/maciejfaltynski/Documents/Zeszyt1.csv";
//List<Tools> list = new List<Tools>();
//using FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
//byte[] buf = new byte[1024];
//int c;
//while ((c = fs.Read(buf, 0, buf.Length)) > 0)
//{
//    string text = Encoding.UTF8.GetString(buf, 0, c);
//}

//var lines = File.ReadAllLines(path);

//using FileStream fs = File.OpenWrite(path);
//using StreamWriter sw = new StreamWriter(fs);
//sw.WriteLine("6,Wiertlo9,1");

//using StreamWriter sw = File.AppendText(path);
//sw.WriteLine("7,Fr8R4,2");


//List<Tools> list = new List<Tools>();
//list.Add(new Tools(1, "Frez", 2));
//list.Add(new Tools(3, "Frez10", 2));
//list.Add(new Tools(2, "Wiertlo", 1));

//string output = JsonConvert.SerializeObject(list);

//var tools = JsonConvert.DeserializeObject<List<Tools>>(output);

//using StreamWriter sw = new StreamWriter(@"/Users/maciejfaltynski/Documents/json.txt");
//using JsonWriter writer = new JsonTextWriter(sw);
//JsonSerializer serializer = new JsonSerializer();
//serializer.Serialize(writer, list);






//XmlRootAttribute root = new XmlRootAttribute();
//root.ElementName = "Tools";
//root.IsNullable = true;
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Tools>),root);
//using StreamWriter sw = new StreamWriter(@"/Users/maciejfaltynski/Documents/Kurs.xml");
//xmlSerializer.Serialize(sw, list);

//string xml = File.ReadAllText(@"/Users/maciejfaltynski/Documents/Kurs.xml");
//StringReader stringReader = new StringReader(xml) ;
//var xmlTools = (List<Tools>)xmlSerializer.Deserialize(stringReader);


//var tool = (from i in list
//            where i.TypeId == 2
//            select i).ToList();







//var toolsChains = list.Where(i => i.TypeId == 2).ToList();
//var toolsChains2 = list.OrderBy(i => i.TypeId);
//var toolsChains3 = list.Where(i => i.TypeId == 2).Select(i => i.Id).ToList();
//var toolsChains4 = list.Where(i => i.TypeId == 2).Select(i =>  new {IdOfElement= i.Id, NameOfElement = i.Name}).ToList();

//var selectedTool = list.FirstOrDefault(i => i.Id == 1);





//			List<int> list = new List<int>();
//			list.Add(1);
//			list.Add(2);
//			list.Add(3);

//			Dictionary<int, Tools> dictionary = new Dictionary<int, Tools>();   //przechwouje pare klucz i wartosc
//			dictionary.Add(1, new Tools() { Id = 1, Name = "Frez", TypeId = 2 });
//			dictionary.Add(2, new Tools() { Id = 2, Name = "Wiertlo", TypeId = 1 });
//			dictionary.ContainsKey(1);
//			Tools tool;
//			dictionary.TryGetValue(2, out tool);

//			SortedList<int, Tools> sortedList = new SortedList<int, Tools>();
//            sortedList.Add(2, new Tools() { Id = 1, Name = "Frez", TypeId = 2 });
//            sortedList.Add(1, new Tools() { Id = 2, Name = "Wiertlo", TypeId = 1 });

//			Queue<Tools> queue = new Queue<Tools>();
//			queue.Enqueue(new Tools() { Id = 1, Name = "Frez", TypeId = 2 });
//			queue.Enqueue(new Tools() { Id = 21, Name = "Wiertlo", TypeId = 1 });
//			var queueTool= queue.Dequeue();// zostanie usuniety pierwszy element ktory zostal dodoany
//			queue.Peek(); // pokazuje jaki jest pierwszy element

//			Stack<Tools> stack = new Stack<Tools>(); //stos LIFO
//			stack.Push(new Tools() { Id = 1, Name = "Frez", TypeId = 2 });
//			stack.Push(new Tools() { Id = 2, Name = "Wiertlo", TypeId = 1 });
//			stack.Pop(); // ostatni element zostanie zwrocony i usuniety
//			stack.Peek();
