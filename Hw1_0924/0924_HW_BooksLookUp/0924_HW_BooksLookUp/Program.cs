using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0924_HW_BooksLookUp
{
    class Program
    {
        //結構變數
        struct Books
        {
            public String ISBN;
            public String Name;
            public String Author;
            public String Publisher;
            public String Type;
            public String Price;
        }

    static void Main(string[] args)
        {   string choose1 = "";//獲取選擇
            string choose2 = "";//獲取最終抉擇
            string goon = "y";

            Console.WriteLine("\nHello! Welocome to 'Books Look Up System' !\n\n");
            while (goon == "y") { 
                Console.WriteLine("Please choose what you want to search ? (Please type number)");
                Console.WriteLine("(1)ISBN (2)Book's Name (3)Author (4)Publisher (5)Type (6)Price");
                choose1 = Console.ReadLine();//選擇類別 
                Console.WriteLine("Choose succefully ! Here are the result:\n");
                What(choose1,"0","0");//將該類別的選項列出
                Console.WriteLine("Please choose which do you want ? (Please type number)");
                choose2 = Console.ReadLine();//選擇類別
                What(choose1,choose2,"1");
                Console.WriteLine("\nDo you want to search again ? (Please type y or n)");
                goon = Console.ReadLine();
            }
            Console.WriteLine("\nOkay! Well, Bye bye!!");
            Console.ReadKey();    
        }

    public static void What(string choose1, string choose2, string type)
    {

        //結構陣列
        Books[] book = new Books[] { 
                //科技0~2
                new Books(){ISBN="9789863206927",Name="10種物質改變世界",Author="米奧多尼克",Publisher="天下文化",Type="科技",Price="300"},
                new Books(){ISBN="9789869181945",Name="趨勢未來新策略",Author="歐崇敬",Publisher="秀威經典",Type="科技",Price="340"},
                new Books(){ISBN="9789570528343",Name="科學大家談",Author="張之傑",Publisher="臺灣商務",Type="科技",Price="250"},
                //小說3~5
                new Books(){ISBN="9789865706654",Name="白雪公主：惡童書",Author="笭菁",Publisher="春天",Type="小說",Price="240"},
                new Books(){ISBN="9789865706807",Name="鬼都",Author="笭菁",Publisher="春天",Type="小說",Price="160"},
                new Books(){ISBN="9789861439396",Name="河神的媳婦",Author="梓意",Publisher="邀月文化",Type="小說",Price="200"},
                //商管6~8
                new Books(){ISBN="9789867330666", Name="如何打造企業贏利模式",Author= "劉文智",Publisher= "憲業企管", Type="商管", Price="360"},
                new Books(){ISBN="9789867622570", Name="從管理中創造利潤", Author="孫曉東", Publisher="讀品", Type="商管", Price="280"},
                new Books(){ISBN="9789867600660", Name="IT有什麼明天？",Author= "尼可拉斯．卡爾", Publisher="杜默", Type="商管", Price="250"},
                //歷史10~12
                new Books(){ISBN="9789861204819", Name="神話與意義",Author= "李維史陀", Publisher="麥田", Type="歷史", Price="220"},
                new Books(){ISBN="9789570843590", Name="文明的故事",Author= "潘蜜拉．托勒", Publisher="讀品", Type="歷史",Price= "280"},
                new Books(){ISBN="9789862751879", Name="世界文化遺產",Author= "席梅爾", Publisher="明天國際", Type="歷史", Price="690"},
                //文學13~15
                new Books(){ISBN="9789861894041", Name="走路去巴黎", Author="克雷恩，索爾巴斯", Publisher="格林", Type="文學", Price="399"},
                new Books(){ISBN="9789578246430",Name= "失落的一角",Author= "謝爾．希爾弗斯坦",Publisher= "玉山社", Type="文學", Price="280"},
                new Books(){ISBN="9789861895345",Name= "界線",Author= "許育榮", Publisher="格林",Type= "文學", Price="280"},
                //其他16~18
                new Books(){ISBN="9789861850696", Name="魔術方塊破解密笈",Author= "陸嘉宏", Publisher="高寶", Type="其他", Price="149"},
                new Books(){ISBN="9789860010749", Name="街頭美學：設施公共藝術", Author="林熹俊", Publisher="典藏", Type="其他",Price= "220"},
                new Books(){ISBN="9789864340057", Name="Python程式設計入門",Author= "葉難",Publisher= "博碩文化", Type="其他", Price="620"}
            };
        string tmp_ReChoice = "";
        if (type == "0")
        {
            switch (choose1)
            {
                case "1"://ISBN
                    for (int i = 0; i < 18; i++)
                    {
                        tmp_ReChoice += "(" + i + ") " + book[i].ISBN + "\n";
                    };
                    Console.WriteLine(tmp_ReChoice);
                    break;
                case "2"://Name
                    for (int i = 0; i < 18; i++)
                    {
                        tmp_ReChoice += "(" + i + ") " + book[i].Name + "\n";
                    };
                    Console.WriteLine(tmp_ReChoice);
                    break;
                case "3"://Author
                    int countA = 0;
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Author == book[j].Author)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                        };
                        if (tf == "t")
                        {
                            tmp_ReChoice += "(" + countA + ") " + book[i].Author + "\n";
                            countA++;
                        }
                        
                    };
                    Console.WriteLine(tmp_ReChoice);
                    break;
                case "4"://Publisher
                    int count = 0;
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Publisher == book[j].Publisher)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                        };
                        if (tf == "t")
                        {
                            tmp_ReChoice += "(" + count + ") " + book[i].Publisher + "\n";
                            count++;
                        }                       
                    }
                    Console.WriteLine(tmp_ReChoice);
                    break;
                case "5"://Type
                    tmp_ReChoice += "(0) " + book[0].Type + " (1) " + book[3].Type + " (2) " + book[6].Type + " (3) " + book[9].Type + " (4) " + book[12].Type + " (5) " + book[15].Type;
                    Console.WriteLine(tmp_ReChoice);
                    break;
                case "6"://Price
                    int countP = 0;
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Price == book[j].Price)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                        };
                        if (tf == "t")
                        {
                            tmp_ReChoice += "(" + countP + ") " + book[i].Price + "\n";
                            countP++;
                        }
                    } Console.WriteLine(tmp_ReChoice);
                    break;
            }
        }//type=0
        if (type == "1")
        {
            int tmp = Int32.Parse(choose2);//轉數字
            switch (choose1)
            {
                case "1"://ISBN
                    Console.WriteLine("\nISBN：" + book[tmp].ISBN + "\n書名：" + book[tmp].Name + "\n作者：" + book[tmp].Author + "\n出版社：" + book[tmp].Publisher + "\n類型：" + book[tmp].Type + "\n價格：" + book[tmp].Price);
                    break;
                case "2"://Name
                   Console.WriteLine("\nISBN：" + book[tmp].ISBN + "\n書名：" + book[tmp].Name + "\n作者：" + book[tmp].Author + "\n出版社：" + book[tmp].Publisher + "\n類型：" + book[tmp].Type + "\n價格：" + book[tmp].Price);
                    break;
                case "3"://Author
                    int countA = 0;
                    int countAA=0;
                    string tmpA = "";
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if(tmp==0 && i==0)
                            Console.WriteLine("\nISBN：" + book[i].ISBN + "\n書名：" + book[i].Name + "\n作者：" + book[i].Author + "\n出版社：" + book[i].Publisher + "\n類型：" + book[i].Type + "\n價格：" + book[i].Price);
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Author == book[j].Author)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                            if (tf == "t")
                            {
                                countA++;
                                if (countA == tmp)
                                    tmpA = book[countAA].Author;
                            }
                        };
                        countAA++;
                    };
                    for (int k = 0; k < 18; k++) {
                        if (tmpA == book[k].Author) {
                            Console.WriteLine("\nISBN：" + book[k].ISBN + "\n書名：" + book[k].Name + "\n作者：" + book[k].Author + "\n出版社：" + book[k].Publisher + "\n類型：" + book[k].Type + "\n價格：" + book[k].Price);
                        }
                    }                   
                    break;
                case "4"://Publisher
                   int countP = 0;
                    int countPP=0;
                    string tmpP = "";
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if(tmp==0 && i==0)
                            Console.WriteLine("\nISBN：" + book[i].ISBN + "\n書名：" + book[i].Name + "\n作者：" + book[i].Author + "\n出版社：" + book[i].Publisher + "\n類型：" + book[i].Type + "\n價格：" + book[i].Price);
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Publisher == book[j].Publisher)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                            if (tf == "t")
                            {
                                countP++;
                                if (countP == tmp)
                                    tmpP = book[countPP].Publisher;
                            }
                        };
                        countPP++;
                    };
                    for (int k = 0; k < 18; k++) {
                        if (tmpP == book[k].Publisher) {
                            Console.WriteLine("\nISBN：" + book[k].ISBN + "\n書名：" + book[k].Name + "\n作者：" + book[k].Author + "\n出版社：" + book[k].Publisher + "\n類型：" + book[k].Type + "\n價格：" + book[k].Price);
                        }
                    }                   
                    break;
                case "5"://Type
                    if (tmp == 0){
                    Console.WriteLine("\nISBN：" + book[0].ISBN + "\n書名：" + book[0].Name + "\n作者：" + book[0].Author + "\n出版社：" + book[0].Publisher + "\n類型：" + book[0].Type + "\n價格：" + book[0].Price);
                    Console.WriteLine("\nISBN：" + book[1].ISBN + "\n書名：" + book[1].Name + "\n作者：" + book[1].Author + "\n出版社：" + book[1].Publisher + "\n類型：" + book[1].Type + "\n價格：" + book[1].Price);
                    Console.WriteLine("\nISBN：" + book[2].ISBN + "\n書名：" + book[2].Name + "\n作者：" + book[2].Author + "\n出版社：" + book[2].Publisher + "\n類型：" + book[2].Type + "\n價格：" + book[2].Price);
                    }
                    if (tmp == 1)
                    {
                        Console.WriteLine("\nISBN：" + book[3].ISBN + "\n書名：" + book[3].Name + "\n作者：" + book[3].Author + "\n出版社：" + book[3].Publisher + "\n類型：" + book[3].Type + "\n價格：" + book[3].Price);
                        Console.WriteLine("\nISBN：" + book[4].ISBN + "\n書名：" + book[4].Name + "\n作者：" + book[4].Author + "\n出版社：" + book[4].Publisher + "\n類型：" + book[4].Type + "\n價格：" + book[4].Price);
                        Console.WriteLine("\nISBN：" + book[5].ISBN + "\n書名：" + book[5].Name + "\n作者：" + book[5].Author + "\n出版社：" + book[5].Publisher + "\n類型：" + book[5].Type + "\n價格：" + book[5].Price);
                    }
                    if (tmp == 2)
                    {
                        Console.WriteLine("\nISBN：" + book[6].ISBN + "\n書名：" + book[6].Name + "\n作者：" + book[6].Author + "\n出版社：" + book[6].Publisher + "\n類型：" + book[6].Type + "\n價格：" + book[0].Price);
                        Console.WriteLine("\nISBN：" + book[7].ISBN + "\n書名：" + book[7].Name + "\n作者：" + book[7].Author + "\n出版社：" + book[7].Publisher + "\n類型：" + book[7].Type + "\n價格：" + book[1].Price);
                        Console.WriteLine("\nISBN：" + book[8].ISBN + "\n書名：" + book[8].Name + "\n作者：" + book[8].Author + "\n出版社：" + book[8].Publisher + "\n類型：" + book[8].Type + "\n價格：" + book[2].Price);
                    }
                    if (tmp == 3)
                    {
                        Console.WriteLine("\nISBN：" + book[9].ISBN + "\n書名：" + book[9].Name + "\n作者：" + book[9].Author + "\n出版社：" + book[9].Publisher + "\n類型：" + book[9].Type + "\n價格：" + book[9].Price);
                        Console.WriteLine("\nISBN：" + book[10].ISBN + "\n書名：" + book[10].Name + "\n作者：" + book[10].Author + "\n出版社：" + book[10].Publisher + "\n類型：" + book[10].Type + "\n價格：" + book[10].Price);
                        Console.WriteLine("\nISBN：" + book[11].ISBN + "\n書名：" + book[11].Name + "\n作者：" + book[11].Author + "\n出版社：" + book[11].Publisher + "\n類型：" + book[11].Type + "\n價格：" + book[11].Price);
                    }
                    if (tmp == 4)
                    {
                        Console.WriteLine("\nISBN：" + book[12].ISBN + "\n書名：" + book[12].Name + "\n作者：" + book[12].Author + "\n出版社：" + book[12].Publisher + "\n類型：" + book[12].Type + "\n價格：" + book[12].Price);
                        Console.WriteLine("\nISBN：" + book[13].ISBN + "\n書名：" + book[13].Name + "\n作者：" + book[13].Author + "\n出版社：" + book[13].Publisher + "\n類型：" + book[13].Type + "\n價格：" + book[13].Price);
                        Console.WriteLine("\nISBN：" + book[14].ISBN + "\n書名：" + book[14].Name + "\n作者：" + book[14].Author + "\n出版社：" + book[14].Publisher + "\n類型：" + book[14].Type + "\n價格：" + book[14].Price);
                    }
                    if (tmp == 5)
                    {
                        Console.WriteLine("\nISBN：" + book[15].ISBN + "\n書名：" + book[15].Name + "\n作者：" + book[15].Author + "\n出版社：" + book[15].Publisher + "\n類型：" + book[15].Type + "\n價格：" + book[15].Price);
                        Console.WriteLine("\nISBN：" + book[16].ISBN + "\n書名：" + book[16].Name + "\n作者：" + book[16].Author + "\n出版社：" + book[16].Publisher + "\n類型：" + book[16].Type + "\n價格：" + book[16].Price);
                        Console.WriteLine("\nISBN：" + book[17].ISBN + "\n書名：" + book[17].Name + "\n作者：" + book[17].Author + "\n出版社：" + book[17].Publisher + "\n類型：" + book[17].Type + "\n價格：" + book[17].Price);
                    } 
                    break;
                case "6"://Price
                    int cP = 0;
                    int cPP=0;
                    string tpP = "";
                    for (int i = 0; i < 18; i++)
                    {
                        string tf = "t";//初始t，代表沒有重複
                        if(tmp==0 && i==0)
                            Console.WriteLine("\nISBN：" + book[i].ISBN + "\n書名：" + book[i].Name + "\n作者：" + book[i].Author + "\n出版社：" + book[i].Publisher + "\n類型：" + book[i].Type + "\n價格：" + book[i].Price);
                        if (i > 0)//從第二項後開始判斷
                        {
                            for (int j = i + 1; j < 18; j++)
                            {
                                if (book[i].Price == book[j].Price)//判斷後面有沒有重複
                                    tf = "f";//有則改為f
                            };
                            if (tf == "t")
                            {
                                cP++;
                                if (cP == tmp)
                                    tpP = book[cPP].Price;
                            }
                        };
                        cPP++;
                    };
                    for (int k = 0; k < 18; k++) {
                        if (tpP == book[k].Price) {
                            Console.WriteLine("\nISBN：" + book[k].ISBN + "\n書名：" + book[k].Name + "\n作者：" + book[k].Author + "\n出版社：" + book[k].Publisher + "\n類型：" + book[k].Type + "\n價格：" + book[k].Price);
                        }
                    }                   
                    break;
            }
        }//type=0
    }
    }      

}
