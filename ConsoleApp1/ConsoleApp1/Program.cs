using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    public class Students
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public int Id { get; set; }
    }
    public class Purchase
    {
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public int PurQty { get; set; }
    }
    class ItemProp
    {
        public int Id { get; set; }
        public string ItemName { get; set; }

        public static List<ItemProp> GetItemMast()
        {
            List<ItemProp> itemlist = new List<ItemProp>();
            itemlist.Add(new ItemProp() { Id = 1, ItemName = "Biscuit  " });
            itemlist.Add(new ItemProp() { Id = 2, ItemName = "Honey    " });
            itemlist.Add(new ItemProp() { Id = 3, ItemName = "Butter   " });
            itemlist.Add(new ItemProp() { Id = 4, ItemName = "Brade    " });
            itemlist.Add(new ItemProp() { Id = 5, ItemName = "Honey    " });
            itemlist.Add(new ItemProp() { Id = 6, ItemName = "Biscuit  " });
            return itemlist;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //1//int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var res = from num in array
            //          where num % 2 == 0
            //          select num;
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}


            //2//int[] array = new int[] { 0, 1, -2, 3, -5, 6, -7, 9, 10 };
            //var res = from num in array
            //          where num > 0
            //          select num;
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}


            //3//int[] array = new int[] {5,6,8,9};
            //var res = from num in array
            //          select num;
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i*i);
            //}


            //4//int[] array = new int[] { 1, 1, 2, 3, 2, 5, 2, 2 };
            //var res = from x in array
            //          group x by x into y
            //          select y;
            //foreach (var arrNo in res)
            //{
            //    Console.WriteLine(arrNo.Key + " appears " + arrNo.Count() + " times");
            //}


            //5//string word = "apple";
            //var res = from x in word
            //          group x by x into y
            //          select y;
            //foreach (var arrNo in res)
            //{
            //    Console.WriteLine(arrNo.Key + " appears " + arrNo.Count() + " times");
            //}


            //6//string[] array = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //var res = from num in array
            //          select num;
            //foreach (var arrNo in res)
            //{
            //    Console.WriteLine(arrNo);
            //}


            //7//int[] array = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //var res = from x in array
            //          group x by x into y
            //          select y;
            //foreach (var arrNo in res)
            //{
            //    Console.WriteLine(arrNo.Key + "\t"+ arrNo.Key * arrNo.Count() + "\t" + arrNo.Count());
            //}


            //8//string[] array = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //var res = array.Where(arr => arr.StartsWith("A") && arr.EndsWith("M"));
            //var res = from x in array
            //          where x.StartsWith("A") && x.EndsWith("M")
            //          select x;
            //foreach (var arrNo in res)
            //{
            //    Console.WriteLine(arrNo);
            //}


            //9//int[] array = new int[] {55 ,200 ,740 ,76 ,230 ,482 ,95 };
            //var res = from num in array
            //          where num > 80
            //          select num;
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}


            //10//List<int> templist = new List<int>();
            //Console.Write("Index : ");
            //int index = int.Parse(Console.ReadLine());
            //for (int i = 0; i < index; i++)
            //{
            //    Console.Write($"Member {i} : ");
            //    int memberValue = int.Parse(Console.ReadLine());
            //    templist.Add(memberValue);
            //}          
            //Console.Write("Index : ");
            //int limit = int.Parse(Console.ReadLine());
            //var res = from num in templist
            //          where num > 59
            //          select num;
            //foreach (int i in res) { Console.WriteLine("Input the value above you want to display the members of the List : "); }


            //11//List<int> templist = new List<int>();
            //templist.Add(5);
            //templist.Add(7);
            //templist.Add(13);
            //templist.Add(24);
            //templist.Add(6);
            //templist.Add(9);
            //templist.Add(8);
            //templist.Add(7);
            //templist.Sort();
            //templist.Reverse();
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(templist[i]);
            //}


            //12//var a = " this IS a STRING";
            //var upper = a.Split(' ')
            //    .Where(s => String.Equals(s, s.ToUpper()));
            //foreach (var s in upper)
            //{
            //    Console.WriteLine(s);
            //}


            //13//string[] array = { "cat", "dog", "rat" };
            //string result = string.Join(", ", array);
            //Console.WriteLine(result);


            //15//string[] array = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //var a = from x in array
            //        group x by x into y
            //        select y;
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x.Key + " appears " + x.Count() + " times");
            //}


            //17//List<char> list = new List<char>();
            //list.Add('m');
            //list.Add('n');
            //list.Add('o');
            //list.Add('p');
            //list.Add('q');
            //var arr = list.Where(o => o != 'o').ToArray();
            //foreach (char c in arr) {Console.WriteLine(c);}


            //20//List<char> list = new List<char>();
            //list.Add('m');
            //list.Add('n');
            //list.Add('o');
            //list.Add('p');
            //list.Add('q');
            //var arr = list.Where(o => o != list[3]).ToArray();
            //foreach (char c in arr) { Console.WriteLine(c); }


            //21//List<char> list = new List<char>();
            //list.Add('m');
            //list.Add('n');
            //list.Add('o');
            //list.Add('p');
            //list.Add('q');
            //list.RemoveRange(1, 3);
            //foreach (char c in list) { Console.WriteLine(c); }


            //22//string[] array = new string[4]{"this","is","a","string"};

            //birinci yol
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i].Length >= 5) {Console.WriteLine(array[i]);}
            //}

            //ikinci yol
            //var arr = from m in array
            //          where m.Length >= 5
            //          select m;
            //foreach (var m in arr)
            //{ Console.WriteLine(m); }


            //23//char[] charSet = { 'X', 'Y', 'Z' };
            //int[] numSet = { 1, 2, 3, 4 };
            //var cartesianProduct = from charList in charSet
            //                       from numberList in numSet
            //                       select new {charList, numberList} ;
            //foreach (var a in cartesianProduct)
            //{
            //    Console.WriteLine(a);
            //}


            //26//List<Purchase> leftList = new List<Purchase>
            //{
            //new Purchase { ItemID = 1, ItemName = "Biscuit", PurQty = 458 },
            //new Purchase { ItemID = 2, ItemName = "Chocolate", PurQty = 650 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurQty = 800 },
            //};
            //List<Purchase> RightList = new List<Purchase> 
            //{
            //new Purchase { ItemID = 4, ItemName = "Brade", PurQty = 700 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurQty = 900 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurQty = 650 },
            //new Purchase { ItemID = 5, ItemName = "Honey", PurQty = 0 },
            //};
            //var combined = leftList.Concat(RightList);
            //foreach (var item in combined)
            //{
            //    Console.WriteLine("Item Id: {0}, Description: {1}, Quantity : {2}", item.ItemID, item.ItemName, item.PurQty);
            //}


            //28//string[] cities = {"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"};
            //var SortedCity = from c in cities
            //                 orderby c.Length
            //                 select c;
            //foreach (var c in SortedCity) { Console.WriteLine(c); }


            //30//List<ItemProp> itemlist = new List<ItemProp>();
            //var resList = (from c in ItemProp.GetItemMast()
            //               select c.ItemName)                               
            //      .Distinct()
            //      .OrderBy(x => x);
            //foreach (var item in resList) { Console.WriteLine(item); }


        }
    }
}