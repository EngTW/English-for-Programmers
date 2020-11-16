To make the 108 edition of
"Taiwan High School English Reference Vocabulary List"
(《高中英文參考詞彙表》) machine-readable.

# Overview

0. Get .NET SDK with Docker.
   * https://hub.docker.com/_/microsoft-dotnet-sdk/
   * `mcr.microsoft.com/dotnet/sdk:5.0-buster-slim-amd64`
1. Get the original PDF file.
   * ```Bash
     curl -o Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf https://www.ceec.edu.tw/files/file_pool/1/0k213571061045122620/%e9%ab%98%e4%b8%ad%e8%8b%b1%e6%96%87%e5%8f%83%e8%80%83%e8%a9%9e%e5%bd%99%e8%a1%a8%28111%e5%ad%b8%e5%b9%b4%e5%ba%a6%e8%b5%b7%e9%81%a9%e7%94%a8%29.pdf
     ```
2. Make the PDF file easier to process by manually converting it to TXT.
   1. Read data.
      1. Open `Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf`.
      2. CTRL + A (select all text).
      3. CTRL + C (copy).
   2. Write data.
      1. Create `Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf.txt`.
      2. CTRL + V (paste).
3. Verify file integrity.
   * ```Bash
     pushd Data
     sha512sum --check sha512sums.txt
     popd
     ```
4. Clean up the raw data.
   * ```Bash
     dotnet run --project Code/CleanData -- Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf.txt Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf.json
     ```
5. Compile the word list.
   * ```Bash
     dotnet run --project Code/CompileData -- Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.pdf.json Data/Taiwan-high-school-english-reference-vocabulary-list-108-edition.json
     ```

## Taiwan High School English Reference Vocabulary List (《高中英文參考詞彙表》)

Published by Taiwan College Entrance Examination Center
(大學入學考試中心, https://www.ceec.edu.tw/ ).

* The 108 edition (《108參考詞彙表》): https://www.ceec.edu.tw/xcepaper/cont?xsmsid=0J066588036013658199&qunit=0J066616104134302815&sid=0K227548677326460907
* The 91 edition (《91參考詞彙表》): https://www.ceec.edu.tw/SourceUse/ce37/ce37.htm

### Copyright Notice

From the original PDF file (cover page):

> 著作權屬財團法人大學入學考試中心基金會所有，僅供非營利目的使用，轉載請註明出處。若作為營利目的使用，應事前經由財團法人大學入學考試中心基金會書面同意授權。
