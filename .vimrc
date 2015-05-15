
" Show where you are in the file, line and column and %
set ruler

" show letter/numbers in right corner (last line mode)"
set showcmd

" Help when typing commands (after semicolon)
set wildmenu

" Highlight search result
set hlsearch

" Run random lines from text file if they look like vim commands.
" We disable this ablity
set nomodeline

" show line numbers "
set number

" Spaces are better than a tab character
set expandtab
set smarttab

" Who wants an 8 character tab?  Not me!
set shiftwidth=4
set softtabstop=4

" Enable mouse support in console
set mouse=a

" This is totally awesome - remap jj to escape in insert mode.  You'll never type jj anyway, so it's great!
inoremap jj <Esc>

" Not sure why this line is here, it relates to the previous one (mapping jj to <Esc>)
nnoremap JJJJ <Nop>

" Number of undo levels
set undolevels=1000
" Backspace behaviour
set backspace=indent,eol,start

set showmatch	" Highlight matching brace

" Indentation
set autoindent
set smartindent

"This unsets the -last search pattern- register by hitting return
nnoremap <CR> :noh<CR><CR>

" Not 100% what this does but seen it a couple ot times
filetype plugin indent on
syntax on

" change to custom color scheme
colorscheme twilight

" tell vim to expect 256 colors (some terminals may not support so many colors?)
set t_Co=256

" highlight current line
set cul
" adjust color, 53 is perfect
hi CursorLine term=none cterm=none ctermbg=53

"Remove all trailing whitespace by pressing F5
nnoremap <F5> :let _s=@/<Bar>:%s/\s\+$//e<Bar>:let @/=_s<Bar>:nohl<CR>

" Set the command window height to 2 lines, to avoid many cases of having to -press <Enter> to continue-
set cmdheight=2

" show location of cursor using a horizontal line. Not sure what this does?
set cursorline

set scrolloff=5               " keep at least 5 lines above/below cursor
set sidescrolloff=5           " keep at least 5 lines left/right cursor

set nocompatible              " vim, not vi

set complete=.,w,b,u,U,t,i,d  " do lots of scanning on tab completion

" Swap ; and :  Convenient. Semi-colon is a rare command. Colon is always!
nnoremap ; :
nnoremap : ;

" Lookup ctags -tags- file up in the directory until one is found 
set tags=tags;/
