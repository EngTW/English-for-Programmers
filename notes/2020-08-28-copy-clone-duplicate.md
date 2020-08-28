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
```
