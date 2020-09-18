```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「狀態」變數
時間 Fri Sep  4 11:55:29 2020
```

本週主週：

* 如何命名「狀態」變數？
  * State, Status 有什麼不一樣？
* 「第Ｎ個」要怎麼說？

* Google 簡報 https://bit.ly/2GtLobb
* GitHub 討論  https://bit.ly/321ResR

---
# State

## 語源、語意

* 1200 年代
  * 人 / 物的暫時屬性、狀態
  * 狀況、情況
  * 社會地位
* 13 世紀後期：形、結構的物理形態
* 1530 年代：情緒、心理狀態
* 今日：人 / 物在特定時間點的狀態

## 案例

* finite-state machine 有限狀態機
* state of matter 物質狀態（固態、液態、氣態）
* 電腦科學：資訊系統、程式的狀態；記憶事件歷程的功能
  * stateful 有狀態的
  * stateless 無狀態的
* .NET Threading `ThreadState`
  * Running, Stopped, Suspended
* .NET Data `ConnectionState`
  * Closed, Open, Connecting, Executing

## 參考資料

* https://www.etymonline.com/word/state
* https://www.lexico.com/definition/state
* https://www.merriam-webster.com/dictionary/state
* https://en.wikipedia.org/wiki/State_(computer_science)
* https://en.wikipedia.org/wiki/Finite-state_machine
* https://en.wikipedia.org/wiki/State_of_matter
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.threadstate?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.data.connectionstate?view=netcore-3.1

---
# Status

## 語源、語意

* 1670 年代：情況、狀況的高峰
* 1791 ：人的法律地位
* 1920 ：人的職業、社會地位
* 今日：情景、整體脈絡的狀態

## 案例

* exit status 退出狀態
* status bar 狀態列
* .NET Net `HttpStatusCode`
  * OK, NotFound, InternalServerError
* .NET Threading `TaskStatus`
  * Created, Running, Canceled

## 參考資料

* https://www.etymonline.com/word/status
* https://www.lexico.com/definition/status
* https://www.merriam-webster.com/dictionary/status
* https://en.wikipedia.org/wiki/Exit_status
* https://en.wikipedia.org/wiki/Status_bar
* https://docs.microsoft.com/en-us/dotnet/api/system.net.httpstatuscode?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskstatus?view=netcore-3.1

---
# State, Status 有什麼不一樣？

state, status 都能讓讀者聯想到「狀態」這個觀念，就看你想強調哪一個面向。

* 語源都可追溯至拉丁文的 status ：「狀態、形態、樣子、位置」

* state 傾向「個體『狀態』屬性」
  * finite-state machine 有限狀態機
  * state of matter 物質形態（固態、液態、氣態）
  * .NET ConnectionState, WebSocketState, ThreadState

* status 傾向「就整體脈絡的綜合判斷；事態、情況的『狀態』」
  * exit status 退出狀態
  * status bar 狀態列
  * .NET FtpStatusCode, HttpStatusCode, TaskStatus

例如說，在某個邏輯模型裡，可能是這樣子界定 state, status ：

* 某個運算單元
  * state: { 讀資料, 寫資料, 解碼, 執行指令, 閒置 } ← 此個體當前的狀態
  * status: { 忙碌, 閒置 } ← 就整體脈絡的綜合判斷

也就是看寫程式的人想要如何定義「個體狀態 vs. 整體脈絡」。

## 參考資料

* https://docs.microsoft.com/en-us/dotnet/api/system.data.connectionstate?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.net.websockets.websocketstate?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.threadstate?view=netcore-3.1

* https://docs.microsoft.com/en-us/dotnet/api/system.net.ftpstatuscode?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.net.httpstatuscode?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskstatus?view=netcore-3.1

---
# 「第Ｎ個」 / 序數 / 個體在群體中的位置、索引

題目出處： https://github.com/EngTW/English-for-Programmers/issues/53

> 你好，我最近在處理股票資料的api，
> 有一個內容是我想要將資料整理成K線的形式，
> 我的Kbar calss中想要存「屬於今天中的第N根Kbar」，這種狀況要怎麼命名呢。
> 像是以一根10:00~ 10:15的15分鐘k線，8:45開盤，這個變數會存5，代表是今天
> 的第六根K線

要表示個體在群體中的「第Ｎ個」，可以用 "ordinal" 這個字，它是
「序數 (ordinal number)」的縮寫。

例如 .NET DataColumn 的 `Ordinal` 屬性，代表一 DataColumn 物件在其所屬的
DataColumnCollection 中的位置（第Ｎ個）。

要表示「個體在群體中的位置、索引」，也可以參考以下這些字，選擇最符合你想
表達的語意：

* index 索引
* id
* key
* name 名字
* title 標題

## 參考資料

* https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumn.ordinal?view=netcore-3.1

感謝參與 https://github.com/EngTW/English-for-Programmers/issues/53 討論
的網友。

---
# 結語

適當的命名可以幫助你的讀者了解你的程式碼的意圖，降低溝通成本，減少誤會的
機率。

這系列文章將繼續從語源資料、實用性的角度，探討《程式英文》字彙的語意、使
用情景，幫助大家提昇程式碼的可讀性。

歡迎推文留言討論、提問 :)

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1599191750.A.773.html
推 jasonwung: 推 09/04 12:18
推 sniper2824: 推個 09/04 12:21
推 ihave3cm: 推起來 09/04 12:47
推 deathlightx: 此系列，必推 09/04 13:14
推 summerleaves: 有看有推 09/04 13:25
推 newhandfun: 推 09/04 13:25
推 qaz0101: 受益良多，必推 09/04 14:42
推 ian90911: 推 09/04 15:19
推 BlazarArc: 推 09/04 16:28

謝謝 :)

推 unmolk: 推！想看property attribution之類的要怎麼用 09/04 17:12

目前有一個題目是關於「屬性： attribute vs. property 」，我想知道這與你想
知道的 property, attribution 是同個方向嗎？如果不是，能否描述一下你的疑
問？ :)

https://github.com/EngTW/English-for-Programmers/issues/25

噓 B0988698088: 小建議：結論可以放前面嗎？上面那些單字個別解說放 09/04 17:41
→ B0988698088: 後面有興趣的自己會去延伸閱讀 09/04 17:41

了解，結論放前面對讀者來說比較省時省力。

推 uopsdod: 推 09/04 18:24
推 lairx: 推 09/04 18:47
推 CaptPlanet: 不錯勃 有點東西 09/04 19:33
推 jack42107: 推這系列 感謝用心 09/04 20:23
推 Ouranos: 推推! 謝謝分享 :) 09/04 21:11
推 ddoy7: 推 09/04 21:19

謝謝各位的欣賞 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/04/2020 23:34:14
推 obamina48: 推！受益良多！ 09/04 23:39
推 l823qqqqqqqq: 感謝分享，有獲得啟發 09/04 23:47

謝謝 :)

推 unmolk: 喔對我打錯了 是attribute XD 感謝分享！ 09/05 00:09

了解 :)

推 CoNsTaR: context, env: 環境狀態 09/05 04:46
→ CoNsTaR: 也可以講一下 has, with, is, at... 也可以命名狀態變數 09/05 04:46

謝謝你提供題目 :) 我把它整理成以下項目，能否請你看看與你想的方向是否一致
？謝謝 :)


* 環境狀態： context, environment 有什麼不一樣？
  * https://github.com/EngTW/English-for-Programmers/issues/56

* 介詞: with, at, from, to, in, than, ... 使用情景
  * https://github.com/EngTW/English-for-Programmers/issues/57

* 現在簡單式(simple present)的使用情景
  * https://github.com/EngTW/English-for-Programmers/issues/58

* 更多「狀態」變數的實例
  * https://github.com/EngTW/English-for-Programmers/issues/59
※ 編輯: AmosYang (136.56.13.184 美國), 09/05/2020 08:53:36
推 ingramchen: 通通用status，state 留給 framework 用 09/05 11:48

很有趣的想法，折衷/經驗法則。
※ 編輯: AmosYang (136.56.13.184 美國), 09/06/2020 01:53:41
推 changyuheng: 推 09/06 02:50

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/06/2020 08:00:30
推 alihue: 推 09/06 12:46

謝謝 :)

→ geminitw: 程設英文 09/06 23:27

謝謝你的建議 :)

我對這個也很好奇，就台灣的語文習慣而言，《English for Programmers》怎麼
翻會比較好？

* 直譯「程式設計師英文」
* 目前稱作「程式英文」
* 鄉民 geminitw 推文提案「程設英文」
* 縮寫提案「程英」 XD

我當初是以 Google, books.com.tw 的搜尋結果為基準，「程式」似乎是最常用的
詞，就先用《程式英文》這個名字；我想知道就鄉民的中文語感來說，覺得如何。 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/07/2020 01:37:07
推 geminitw: Ex:商用英文 程設英文除了變數及函數命名 註解及技術文 09/07 20:10
→ geminitw: 件才是重點 09/07 20:10

我再查了一下，從 Google 得到的數據是

* "程式書": 10900
* "程設書": 64

* "程式課": 33400
* "程設課": 5700

* "程式課程": 107000
* "程設課程": 1400

* "程式訓練": 15000
* "程設訓練": 284

似乎在「描述 "programming" 這個概念上」，「程式」比「程設」更為通用？

---
> 除了變數及函數命名 註解及技術文件才是重點

十分同意；我還沒機會去研究這個，但有個東西叫 "controlled natural language",
可說是「簡化了的自然語言」 (*1) ；可用在「針對特定技術領域，方便母語非英
文者溝通」上。

或許適合用來寫註解、技術文件。

---
*1: 限定使用相對簡單的文法與字彙，例如：

* 把句子寫短
* 避免使用代名詞
* 使用主動語氣

## 參考資料

* https://en.wikipedia.org/wiki/Controlled_natural_language
  * https://en.wikipedia.org/wiki/Attempto_Controlled_English

推 Tatum0119: 很棒 推 09/07 22:57
推 iwillbehere: 推 09/08 13:57

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/09/2020 20:48:53
推 ygl01181: 推 09/14 07:32
推 NCUcsie105: 推 09/15 08:29

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 12:17:29
```
