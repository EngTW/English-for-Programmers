```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「複製」功能
時間 Fri Aug 28 11:52:49 2020
```

這週的主題是「複製」： Copy, Clone, Duplicate 。

我們將從語源學的角度來分析 copy, clone, duplicate 的「複製」語意差別，辨
別什麼情況適合用哪個字。

* Google 簡報 https://bit.ly/3guPFaE
* GitHub 討論  https://bit.ly/321ResR

---
# Copy

copy 起源於 14 世紀後期，原意是「抄寫複製文字/文件」；在 1950 年代開始用
來描述「複製電腦資料」，到今日「電腦資料」包含了從文字到影音的各種數位化
資料、檔案。

## 語源

* 14 世紀後期：抄寫、複製文字/文件
* 1640 年代：模仿
* 1953 ：複製電腦資料
* 1983 ：送一份 文件/信/email 給第三方

## 案例

* 複製電腦檔案/資料
  * 網頁內容（文字、圖片、影音）
  * .NET `File.Copy()`
* 影印機(copy machine)
* 複製保護(copy protection)
* 著作權(copyright)

## 參考資料

* https://www.etymonline.com/word/copy
* https://www.lexico.com/definition/copy
* https://en.wikipedia.org/wiki/Copy

---
# Clone

clone 是相對近代（ 1903 年）才出現的字，原意是「一群從母體分支移植培育的
植物」，在 1970 年代開始被用來描述「在遺傳基因層級複製人/動物」的觀念，
例如 1973 年的電影《The Clones》，即是以「複製人」為劇情設定。

目前沒有足夠資料來推論 clone 這個字是怎麼轉移到電腦領域的，我能找到的最
早的紀錄是 Linux 1.0.0 版（於 1994 年 3 月釋出）有 `clone` system call 。

## 語源

* 1903 ：（植物學）一群從母體分支移植培育的植物
* 1959 ：開始被當作動詞使用
* 1970 ：由單個細胞開始、在遺傳基因層級複製人/動物
* 1994 ： Linux 1.0.0 system call `clone(2)`

## 案例

* Git `clone`
* Linux system call `clone(2)`
  * Java Object `clone()`
  * .NET ICloneable `clone()`
* 複製品
  * Diablo clone 類/仿 Diablo 的遊戲
  * Facebook clone 類/仿 Facebook 的網站

## 參考資料

* https://www.etymonline.com/word/clone
* https://www.lexico.com/definition/clone
* https://en.wikipedia.org/wiki/Clone
* https://en.wikipedia.org/wiki/Fork_(system_call)#Clone
* https://man7.org/linux/man-pages/man2/syscalls.2.html
* https://www.imdb.com/title/tt0071336/

---
# Duplicate

duplicate 起源於 15 世紀，形容「雙份的」，作為動詞「把東西複製成雙份」，
或是指「（之於某物）一模一樣的東西」。

## 語源

* 15 世紀早期：雙份的
* 15 世紀晚期：複製成雙份
* 1530 ：（之於某物）一模一樣的東西

## 案例

* .NET Linq `DuplicateKeyException`
* 代碼重複/複製 duplicate code
* 遊戲中複製物品 dupe / duping

## 參考資料

* https://www.lexico.com/definition/duplicate
* https://www.etymonline.com/word/duplicate
* https://en.wikipedia.org/wiki/Duplication
* https://en.wikipedia.org/wiki/Duplicate_code
* https://en.wikipedia.org/wiki/Duping_(video_games)

---
# Copy, Clone, Duplicate 有什麼不一樣？

作為動詞時， copy, clone, duplicate 都能讓讀者聯想到「複製」這個觀念，就
看你想強調「複製」的哪一個面向。

比較特別的是 duplicate 做為形容詞「雙份的」時，則是 copy, clone 無法替換
的；例如下列的 `DuplicateKeyException` 。

* 「抄錄資料」 → copy
  * .NET File.Copy() 複製檔案１的內容到檔案２
  * .NET Array.Copy() 複製陣列１的元素到陣列２
  * .NET List<T>.CopyTo() 複製此串列的元素到串列２

* 「個體繁殖」 → clone
  * Git clone 複製 Git repo
  * .NET Object.MemberwiseClone()  淺 (shallow) 複製此物件

* 「雙份的；製造雙份」 → duplicate
  * .NET Linq DuplicateKeyException 「同樣的物件 key 已存在」例外
  * Office Shape.Duplicate()  複製一形狀 (shape) 物件為雙份

## 參考資料

*
https://docs.microsoft.com/en-us/dotnet/api/system.io.file.copy?view=netcore-3.1
*
https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=netcore-3.1
*
https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.copyto?view=netcore-3.1
* https://git-scm.com/docs/git-clone
*
https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=netcore-3.1
*
https://docs.microsoft.com/en-us/dotnet/api/system.data.linq.duplicatekeyexception?view=netframework-4.8
*
https://docs.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.duplicate?view=office-pia

---
# 「複製」深淺度、連動關係

copy, clone, duplicate 並沒有明確統一的實作慣例。

每套框架可能有它自己的實作風格。

* 深 (deep) 複製 / 淺 (shallow) 複製
* 本體 與 複製體 之間是否有連動關係

---
# 結語

有「複製」語意的字彙不只 copy, clone, duplicate 這三個，但從 GitHub 及
Microsoft doc 取樣的結果來看， copy, clone, duplicate 在程式碼中的出現頻
率比其它「複製」字彙（例如 replicate, mirror, repeat ）來得高，所以先研
究這三個字。

非常感謝參與 https://github.com/EngTW/English-for-Programmers/issues/17
討論的網友。

有任何疑問、建議、感想，歡迎推文留言討論。 :)

---
# 徵求意見回饋

本週簡報有兩個版本：

* 正式發布版： https://bit.ly/3guPFaE (含講者稿)
* 實驗版： https://bit.ly/31yi5w4 (含講者稿)

如果方便的話，請告訴我你對這兩種版本/寫作取向的感覺，謝謝 :)

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1598586794.A.F2D.html
※ 編輯: AmosYang (136.56.13.184 美國), 08/28/2020 11:56:01
推 CaptPlanet: 推 08/28 12:38
推 Aobanan: 推 08/28 12:38
推 hans1461: 推 08/28 13:47
推 ga4567896: 推 08/28 13:56
推 DCTmaybe: 想請問php references的這種情況 $a=&$b; 適合用哪個字? 08/28 14:23
推 lazyfirst: 實驗版和正式發布版的寫作口氣差好多，是大大寫的嗎？ 08/28 14:46
推 sniper2824: 推 08/28 17:37
推 summerleaves: 推文推 08/28 17:59
→ summerleaves: 優** 08/28 17:59
推 alihue: 推 08/28 18:08
推 Ouranos: Amos 必推! 08/28 21:43
推 wulouise: reference是參照不是複製吧 08/28 22:01
推 alihue: 正式版編排比較讀得下去，有別人用法的實務範例好懂很多 08/28 22:12
→ alihue: 工程師比較不喜歡那麼多廢話 想看重點XD 08/28 22:12
推 DCTmaybe: 好像也是，算了當我沒問XD 08/28 22:14
推 brianhsu: 這裡提到的複製應該比較像真的有兩個不同的記憶體區塊但 08/28 23:22
→ brianhsu: 內容相同，單純的兩個 pointer / reference 指到同一個 08/28 23:22
→ brianhsu: 物件好像不太會用這些詞。 08/28 23:22
推 jasonwung: 推 08/29 00:18

謝謝各位的欣賞 :)

---
> 推 DCTmaybe: 想請問php references的這種情況 $a=&$b; 適合用哪個字?
> 推 wulouise: reference是參照不是複製吧
> 推 brianhsu: 這裡提到的複製應該比較像真的有兩個不同的記憶體區塊但
> → brianhsu: 內容相同，單純的兩個 pointer / reference 指到同一個
> → brianhsu: 物件好像不太會用這些詞。

我會從「想聚焦在哪個場景」這個角度來看，例如說，

* 從 `=` 這個 "assignment operator" (指派運算子) 的層級來看，我會用
  "assign" 這個動詞。

* 往實作細節去看的話，我想一定會有以下的動作：「讀取 $b 的 reference 的
  『值』，將其寫入 $a 的儲存空間」；在描述如此「抄寫一個『值』」的動作時
  ，我會用 copy 這個動詞。

* 如果是要強調「已經有了 $b, 現在再多產生一個相等的 $a 」，那我會用
  duplicate 這個動詞。

  而 duplicate 的語意可以是正面也可以是負面，例如說，

  * 我們 duplicate 了 $b, 所以接下來當 $b 消失、被更動，我們還有 $a 可以
    用 ← 在此 duplicate 就是偏向正面的「備份、備援」

  * 我們 duplicate 了 $b, 但後來發現這樣做沒什麼正面效益，可能還多了一個
    變數 $a 要多花心力維護 ← 在此 duplicate 就是偏向負面的「冗贅」

  也就是說， duplicate 比 assign, copy, clone 更能帶出「雙份 / 不止一份」
  的語意。

---
> 推 lazyfirst: 實驗版和正式發布版的寫作口氣差好多，是大大寫的嗎？

不是 :) 但的確是我想要做的實驗，試著找到「簡潔, 好懂, 平易近人」的平衡，
還有不同媒體 (文字、影音) 適合的內容走向。

> 推 alihue: 正式版編排比較讀得下去，有別人用法的實務範例好懂很多
> → alihue: 工程師比較不喜歡那麼多廢話 想看重點XD

十分感謝你的意見回饋 orz 我能體會那種感覺，想要「高密度、以一貫之的實用
資訊」 :D
※ 編輯: AmosYang (136.56.13.184 美國), 08/29/2020 07:28:47
推 unmolk: 推實用！學生受益良多 08/29 09:52

謝謝你的欣賞 :)

推 Csongs: 個人喜歡語源學來了解英文語系的思路，以前學英文字根多少 08/29 11:53
→ Csongs: 就有這個意味 08/29 11:53

十分同意；接觸語源學的資料後，之前一些自己也說不明白的「語感」，也開始變
得更明白。

推 DCTmaybe: 感謝說明～推推 08/29 21:24

不客氣 :)
※ 編輯: AmosYang (136.56.13.184 美國), 08/30/2020 02:36:13
推 BlazarArc: 推 09/01 09:16
推 kyukyu: 09/03 12:12

謝謝 :)

推 APTON: 謝謝！GIT按星星並追蹤了 09/03 12:55
→ APTON: 以後有人故意要戰命名就叫他先看完這個系列！XD 09/03 12:56

謝謝你的欣賞 :)

我猜想，有時候「戰命名」可能就只是每個人心智/邏輯/思維模型不同，抽象層的
分界點不一。

這系列文章是儘量建構於客觀參考資料、應用實例之上，希望能降低因主觀語感而
起爭議的機率。 :D
※ 編輯: AmosYang (136.56.13.184 美國), 09/04/2020 12:12:50
推 janbarry168: 推 09/05 09:59

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/06/2020 08:00:45
```
