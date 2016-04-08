# split the large file into two column files, japanese first
cut -f 1 deduplicated_jp_ex_sentences.txt > jp1.txt
cut -f 2 deduplicated_jp_ex_sentences.txt > en1.txt
# transofrm the english part to be smaller and rearrange #ID
awk -F '#' '{sub("ID=","",$2 );printf("%s\t%s\n",$2,$1);}' en1.txt > en2.txt
# similar for japanese part
awk -F ' A: ' '{sub("#ID=","",$1);printf("%s\t%s\n",$1,$2);}' jp1.txt > jp2.txt
# combine again, with delimeter |, english first
paste -d '|' en2.txt jp2.txt > enjp_strip.txt
# remove ones that are too long
awk 'length < 180' enjp_strip.txt > enjp_short.txt
# shuffle
gsort -R enjp_short.txt > enjp_shuffled.txt
# split into separate, remember english first
cut -d '|' -f 1 enjp_shuffled.txt > en_final_raw.txt
cut -d '|' -f 2 enjp_shuffled.txt > jp_final_raw.txt
# copy latex template
cp latex_template_print_japanese.tex en_print.tex
cp latex_template_print_japanese.tex jp_print.tex
# append to both, now use your hands in vim to fix the file before compiling
cat en_print.tex en_final_raw.txt > en_fixme.tex
cat jp_print.tex jp_final_raw.txt > jp_fixme.tex
