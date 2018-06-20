#Black Jack Game
Windows Forms Project by: Hristijan Jovanovski, Adrian Colak, Leon Janevski

-----------------------------------------------------------------------------------------------------------------------------------

##1. Опис на апликацијата. Апликацијата која ние ја развиваме е класична Black Jack игра за еден играч. Со цел играчот да биде задоволен од играта, нашата апликација ги има сите функционалности на онлајн Black Jack игра и има едноставен дизајн.

Исто така имплементирана е и серијализација, што овозможува играчот во било кој момент од играњето да ја зачува играта и потоа да продолжи од каде што зачувал.

##2. Упатство за користење.

###2.1 Нова игра.
На почетниот прозорец играчот има можност да започне нова игра (New Game) со почетен буџет од 5000 долари, но исто така има можност да отвори веќе зачувана игра (Load Game).

###2.2 Save game. За да се зачува играта, играчот може во секое време преку стандардното мени преку Save да ја зачува својата игра.

###2.3 Load game. Освен на почетокот, играчот може да отвори друга зачувана игра во секое време преку Open во стандардното Windows мени.

###2.4 Правила на игра. #### Правилата се стандардни за Black Jack игра.
- Играчот започнува со 500 долари.
- За да се овозможи започнување на делење на карти, играчот треба да одбери влог. Влогот не е лимитиран.
- Откако ќе бидат поделени картите играчот има четири можности.
  - Играчот е задоволен од своите карти и не сака повеќе карти (Stand копче).
  - Играчот сака да побара уште една карта (Hit копче).
  - Играчот сака да го удвои својот влог и да извлече точно една карта (Double копче). Копчето се овозможува доколку претходно играчот не барал карти и има доволно средства за да го удвои влогот.
  - Доколку при првото делење на картите, двете карти имаат иста вредност, а играчот има доволно средства да го удвои влогот, играчот може да ги подели двете карти во две посебни раце и му се дели на секоја рака уште по една карта во двете раце. Потоа играчот двете раце ги игра посебно (Split копче).
- Казиното бара карти се додека вкупната вредност на картите е помала од 17. Казиното не бара повеќе карти доколку поделените карти се A и 6 (Soft 17).
- Вредноста на A е 11, но доколку вредноста на картите во раката надминува 21, вредноста на A станува 1.
- Доколку играчот победи со Black Jack (А и било која од картите 10, J, Q, K) казиното исплаќа 2.5 од влогот на играчот.

###3 Претставување на проблемот.

###3.1 Податочни структури.
Главните податоци и функции за играта се чуваат во класа public class Form1, а за потребите на серијализацијата се користи и public class BlackJack.

###3.2 Класа Form1.
Ова е главната класа на формата, и во оваа класа се чува објект од класата BlackJack, а исто така се чуваат и функциите кои се користат за поставување на вредностите на копчињата. Преку on-click events на копчињата, се контролира текот на играта.
  - public void newGame()
    Со овој метод креираме нов објект од BlackJack класата и го доделуваме на објектот од класата Form1. Исто така се подесуваат и вредностите на копчињата.
  - public void blackJackWin()
    Овој метод го повикуваме кога играчот победил со Black Jack, добива 2.5 * влогот.
  - public void playerWon()
    Овој метод го повикуваме кога играчот победил, но не со Black Jack, добива 2 * влогот.
  - public void push()
    Овој метод го повикуваме кога играчот и казиното имаат иста вредност, играчот го добива влогот.
  - public void playerLost()
    Овој метод го повикуваме кога играчот губи и не добива ништо.
  - public void newRound()
    Овој метод го повикуваме кога играчот завршил со играње на раката. Ги земаме картите од раката на играчот и казиното и ги ресетираме копчињата. Почетно класата Deck e составена од 4 шпила од 52 карти. Бидејќи картите не се враќаат назад во шпиловите, проверуваме при почеток на нова рунда, доколку имаме помалку од 25 карти, правиме нов Deck од 4 шпила и ги мешаме картите.
  - public void startFirstRound()
    Овој метод се повикува кога играчот ставил почетен влог и стиснал на копчето Deal. Ги подесува вредностите на копчињата.

###3.3 Класа BlackJack
  - Оваа класа се користи како wrapper класа за да се овозможи зачувување на состојбата на играта. За да се овозможи тоа, класата е [Serializable].
  - Во оваа класата се чуваат објектите од класите Dealer, Deck и Player. Исто така се чуваат состојбите на копчињата и на влогот.
  
