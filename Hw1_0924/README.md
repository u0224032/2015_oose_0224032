# 2015_oose_0224032
****

    國立高雄第一科技大學 資訊管理系 二年級B班 0224032 曾琬真
For Class Practice and Homework

***Books Look Up***
## 2015 / 09 / 24 

**This program** is used to look up the books' information.
 
**You can** search by various choices.
 
**This is** a little practice and test just for class. 
 
## That's all ! All the perfect progress will be recorded above this document ! 

#使用案例#
1.	使用者開啟查詢程式
2.	第一階段查詢問候
 	
	i、	誘導式選擇(ISBN、書名、作者、出版社、類型、售價)讓使用者選擇以哪個查詢為主
 
	ii、	使用者回答
3.	第二階段查詢問候
 
	i、	以使用者的回答做第二階段詢問
 
	ii、	以第一個回答做第二題的搜尋索引，列出所有項目讓使用者選擇
 
	iii、	使用者選擇最後確定的目標
4.	根據第二個答案output出正確的詳細資訊
5.	繼續搜尋或離開系統

Ex:
(以書名查詢為例)
進入查詢系統 → 使用者選出第一答案：以書名為第一階查詢 → 以書名為搜尋索引從資料庫顯示所有書名當第二階查詢給使用者作選擇 → 使用者選出書名 → 顯示書本詳細資訊 → 繼續搜尋或離開系統

(以類別查詢為例)
進入查詢系統(圖1) → 使用者選出第一答案：以類別為第一階查詢(圖2) → 以類別為搜尋索引從資料庫顯示所有類別當第二階查詢給使用者作選擇(圖3) → 使用者選出類別(圖3) → 顯示書本詳細資訊(圖3) → 繼續搜尋或離開系統(圖3)
 
圖1 
![圖1](https://fbcdn-sphotos-d-a.akamaihd.net/hphotos-ak-xlf1/v/t1.0-9/12341224_883589638362557_135044168536809753_n.jpg?oh=df48394a6d3666573099c7ca667ae7e0&oe=56E1C68C&__gda__=1457147078_81f1cd257be6ba530c74a9ca916bfba9)
 
圖2 
![圖2](https://fbcdn-sphotos-e-a.akamaihd.net/hphotos-ak-xaf1/v/t1.0-9/12342698_883589628362558_3122485866310624107_n.jpg?oh=6611bc2d66a8dceff36ef24d1d6576ea&oe=56D4AB62&__gda__=1461851603_bcb22d317e96419607f0a8ae94abec25)
 
圖3 
![圖3](https://scontent-tpe1-1.xx.fbcdn.net/hphotos-xat1/v/t1.0-9/12348049_883589625029225_7037809598460606864_n.jpg?oh=b66a109b0c88a6b90cbc4734791403ed&oe=571E0072)
 
# 系統架構圖
使用案例圖 → 
![使用案例圖](https://scontent-tpe1-1.xx.fbcdn.net/hphotos-xaf1/v/t1.0-9/1909735_894968860557968_5307684955234194576_n.jpg?oh=d85b2cb159320a3ecf98294cd15ed6fe&oe=56FC0C43)
 
類別圖 → 
![類別圖](https://scontent-tpe1-1.xx.fbcdn.net/hphotos-xpf1/v/t1.0-9/1880_894968853891302_7840157290992143989_n.jpg?oh=ad60942ce9a7c7318dfbfa70e170d7a5&oe=571379ED)
 
循序圖 → 
![循序圖](https://scontent-tpe1-1.xx.fbcdn.net/hphotos-xpa1/v/t1.0-9/10612741_894968857224635_7676287432140377238_n.jpg?oh=76a2bf4cc3a9f5e3de7c43dbdd075c00&oe=5711BAB8)
 
強韌圖 → 
![強韌圖](https://scontent-tpe1-1.xx.fbcdn.net/hphotos-xaf1/v/t1.0-9/261363_894968873891300_8281483056431889195_n.jpg?oh=07d05d18cd79f54924f195fbcd36a9ff&oe=57135C04)

# 四大開發步驟 
## 1.Requests 
搜尋功能(ISBN、書名、作者、出版社、類型、售價)

類型(科技、小說、商管、歷史、文學、其他)
## 2.Design 
###一、純文字介面(C#)
    定義Books結構變數：
			ISBN(String)
			Name(String)
			Author(String)
			Publisher(String)
			Type(String)
			Price(int)
	主程式：
			1.開場白設計
			2.第一個誘導式問答題(大分類選擇)，讓使用者輸入以哪個做篩選
			3.根據使用者回答跑方法篩選出下一階段的選項
			4.第二個誘導式問答題(細分類選擇)，讓使用者選擇要找的目標
			5.顯示搜尋結果
			6.是否繼續下一筆搜尋(若是則跳由第2步繼續；若否則跳出程式)	

## 3.Coding 
一、純文字介面使用C#開發(僅查詢用)
用console畫面進行查詢

## 4.Test 
一、測試Debug沒問題

