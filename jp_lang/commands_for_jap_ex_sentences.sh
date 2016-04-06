# split the large file into two column files
cut -f 1 mixed_jp_sentences.txt >> jp1.txt
cut -f 2 mixed_jp_sentences.txt >> en1.txt
# transofrm the english part to be smaller and rearrange #ID
awk -F '#' '{sub("ID=","",$2 );printf("%s\t%s\n",$2,$1);}' en1.txt > en2.txt
# similar for japanese part
awk -F ' A: ' '{sub("#ID=","",$1);printf("%s\t%s\n",$1,$2);}' jp1.txt > jp2.txt
