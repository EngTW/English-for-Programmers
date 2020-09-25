```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「分段」功能？
時間 Fri Sep 25 11:13:12 2020
```

# 本週主題 + 結論：

* 分段 Slice, Split 有什麼不一樣？
  * Slice: 從大塊東西上削下小塊
  * Split: 把東西打碎成多塊
* 分開 Detach, Disconnect 有什麼不一樣？
  * Detach: 把東西分開來
  * Disconnect: 切斷（東西中間的）連結
* 分界點 Delimiter 有哪些概念相關字？
  * Separator: 分隔器、分隔物
  * Divider: 空間區塊中的分隔物
  * Splitter: 某些 UI 框架會用 splitter 來代表「分割(split)畫面的 UI 元件」
  * Break: 斷行(line break), 斷頁(page break)

---
* GitHub 討論 https://bit.ly/321ResR
* Google 簡報 https://bit.ly/3mPCOEa

感謝參與 https://github.com/EngTW/English-for-Programmers/issues/35 討論
的網友。

---
# Slice, Split 有什麼不一樣？

* Slice: 從大塊東西上削下小塊
* Split: 把東西打碎成多塊

## Slice

* 語源：古法文 ← 法蘭克文（今法國北部） ← 古德文
  * 1300 年代：名詞「碎片」，動詞「擊碎」
  * 今日
    * 從大塊食物（麵包、肉、蛋糕）切下來的寬薄片狀小塊
    * （特別指食物）將東西切成寬薄片狀小塊
    * 從大塊東西上削下小塊
* 電腦科學例子
  * .NET `Memory<T>.Slice()`
  * .NET `Span<T>.Slice()`
  * "array slicing" 從陣列中切出小陣列
* 日常生活例子
  * 如何切洋蔥 how to slice an onion
  * 如何切鳳梨 how to slice a pineapple

## Split

* 語源：古德文（今德國西部）
  * 1580, 1590 年代：動詞「分裂、裂開」，名詞「裂縫」
  * 1610 年代：「由裂開形成的木塊」
  * 今日
    * （強力）把東西打碎成多塊
    * 分裂、裂痕、裂縫
* 電腦科學例子
  * .NET `Regex.Split()`
  * .NET `String.Split()`
  * Unix `split` 指令（把檔案拆成小塊）
* 日常生活例子
  * 如何分割 iPad 螢幕 how to split screen on iPad

## 參考資料

* https://en.wikipedia.org/wiki/Array_slicing
* https://en.wikipedia.org/wiki/Split_(Unix)
* https://www.etymonline.com/word/slice
* https://www.etymonline.com/word/split
* https://www.lexico.com/en/definition/slice
* https://www.lexico.com/en/definition/split

---
# Detach, Disconnect 有什麼不一樣？

* Detach: 把東西分開來
* Disconnect: 切斷（東西中間的）連結

## Detach

* 語源：古法文
  * 1680 年代、今日：「為了特別的目的，把東西分開來」
* 電腦科學例子
  * .NET `ObjectContext.Detach(object)`
  * Java `VirtualMachine.detach()`
* 日常生活例子
  * 如何在 iMovie 中把聲音分離 how to detach audio in iMovie
  * 如何分開 Surface Book; how to detach Surface Book

## Disconnect

* 語源：拉丁文
  * 1770 年代、今日：「切斷（東西中間的）連結」
* 電腦科學例子
  * .NET `Socket.Disconnect()`
* 日常生活例子
  * 如何移除汽車電池 how to disconnect a car battery
  * 如何移除 PS4 手把 how to disconnect a PS4 controller

## 參考資料

* https://docs.microsoft.com/en-us/dotnet/api/system.data.objects.objectcontext.detach?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.disconnect?view=netcore-3.1
* https://docs.oracle.com/en/java/javase/15/docs/api/jdk.attach/com/sun/tools/attach/VirtualMachine.html#detach()
* https://www.etymonline.com/word/detach
* https://www.etymonline.com/word/disconnect
* https://www.lexico.com/en/definition/detach
* https://www.lexico.com/en/definition/disconnect

---
# Delimiter 有哪些概念相關字？

* 語源：法文 ← 拉丁文
* delimit: 1852 年代，動詞「標記、固定邊界」
* delimiter: 1960 年代、今日，在電腦領域中，用來標記 資料區塊/資料流 起
  始、終結點的字元

## Separator

分隔器、分隔物。

* 語源：拉丁文
  * 14 世紀未期：「把東西拉散開來」
  * 1600 年代：「分離主義者」
  * 1831 年代：「將東西分開來的機械裝置」
  * 今日：分隔器、分隔物
* .NET 例子
  * `System.Windows.Controls.Separator` class; 用來分隔 UI 元件的 UI 元件
  * `String.Join(separator, ...)`; 把字串連接在一起的字串
  * `NumberFormatInfo.NumberDecimalSeparator`; 分隔整數位與小數位的符號
  * `NumberFormatInfo.NumberGroupSeparator`; 分隔整數位群組的符號
  * `Path.PathSeparator`; 分隔檔案路徑的符號
  * `Path.DirectorySeparatorChar`; 分隔檔案路徑中資料夾名稱的符號
* 日常生活例子
  * 電池正負極中間的阻隔物
  * 分離原油中各種成分的分離器
  * 分離乳脂、乳清的分離器

## 參考資料

* https://docs.microsoft.com/en-us/dotnet/api/system.globalization.numberformatinfo.numberdecimalseparator?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.globalization.numberformatinfo.numbergroupseparator?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.io.path.directoryseparatorchar?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.io.path.pathseparator?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.string.join?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.separator?view=netcore-3.1
* https://en.wikipedia.org/wiki/Delimiter
* https://en.wikipedia.org/wiki/Separator_(electricity)
* https://en.wikipedia.org/wiki/Separator_(milk)
* https://en.wikipedia.org/wiki/Separator_(oil_production)
* https://www.etymonline.com/word/delimiter
* https://www.etymonline.com/word/separator
* https://www.lexico.com/en/definition/separator

## Divider

空間區塊中的分隔物。

* 語源：拉丁文
  * divide: 14 世紀早期，「把東西分裂成多塊」
  * divider: 1520 年代，「分配東西的人」
    * 1959 年代、今日，「（尤其指分隔房間的）間隔物、屏風」
    * 今日，「把東西分成多塊的人事物」
* .NET 例子
  * `System.Windows.Forms.DataGridViewRow.DividerHeight`; 資料表格橫列間
    的間隔高度
  * `System.Windows.Forms.DataGridViewColumn.DividerWidth`; 資料表格直列
    間的間隔寬度
* 日常生活例子
  * 文字之間的分隔符號，例如空白、空行
  * 房間中用來隔間的屏風

## 參考資料

* https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn.dividerwidth?view=netcore-3.1
* https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewrow.dividerheight?view=netcore-3.1
* https://en.wikipedia.org/wiki/Word_divider
* https://www.etymonline.com/word/divider
* https://www.lexico.com/en/definition/divider

## 其它： Splitter, Break

* Splitter: 某些 UI 框架會用 splitter 來代表「分割(split)畫面的 UI 元件」
* Break: 斷行(line break), 斷頁(page break)
  * HTML 的 `<br>` 標籤

## 參考資料

* https://en.wikipedia.org/wiki/Line_wrap_and_word_wrap
* https://en.wikipedia.org/wiki/Newline
* https://en.wikipedia.org/wiki/Page_break
* https://html.spec.whatwg.org/#the-br-element

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
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1601003622.A.9E4.html
```
