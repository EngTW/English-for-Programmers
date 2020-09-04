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
```
