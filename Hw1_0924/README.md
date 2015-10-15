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
(以作者查詢為例)
進入查詢系統 → 使用者選出第一答案：以作者為第一階查詢 → 以作者為搜尋索引從資料庫顯示所有作者當第二階查詢給使用者作選擇 → 使用者選出作者 → 顯示書本詳細資訊 → 繼續搜尋或離開系統


# Four develop progress 
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

