https://www.facebook.com/twy30/posts/2623363331247315

# validate vs. verify 🤔

應該可以這麼說：

---
如果在你的邏輯模型中，你選擇把以下兩件事分開來看的話

(a) 此資料是否有效(valid) → 判斷「此資料 是不是 你預期的資料種類(type)？  / 此資料值不值得繼續深入檢視它？ 」

(b) 此資料是否滿足「預期的正確條件/狀態」

這個時候， *可以* 用 validate 表示 (a) 的意圖；用 verify 表示 (b) 的意圖。

---
例如

`bool ValidateAge(string age)`; 傳入 "-3", "foo" 會傳回 false; 傳入 20 會傳回 true

`bool VerifyAge(decimal age)`; 在這個系統中，可能是要確認「成年才能買此商品」，而「成年」在不同地區有不同規定，此 `VerifyAge()` 就會處理「依不同地區的規定去判定此 age 是否成年」這件事。

---
相對的，如果在你的邏輯模型中，你選擇把「資料的有效性(validity)視為『預期的正確條件/狀態』的一部分」的話，那麼，

用 validate 或 verify 都說得通。

---
最後，永遠都可以退一步用 "check" 😅

我相信大多數人都能知道 "check" 的意圖就是「檢查此資料是否符合作者的邏輯模型的條件」 🤔

---
* https://www.ptt.cc/bbs/Soft_Job/M.1597982849.A.9A7.html 如何命名「檢查」功能２
* https://www.ptt.cc/bbs/Soft_Job/M.1597382427.A.19A.html 如何命名「檢查」功能
