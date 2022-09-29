string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз"};
string[] userCards = new string [5];
string[] compCards = new string [5];
int userSum = 0, compSum = 0, userCardsMoveValue = 0, compCardsMoveValue=0, i = 0, j = 0;
string cardsValue = "", userName = String.Empty;

int Exchenge(string card)
{
switch (card)
{
case "2":
cardsValue = "2";
break;
case "3":
cardsValue = "3";
break;
case "4":
cardsValue = "4";
break;
case "5":
cardsValue = "5";
break;
case "6":
cardsValue = "6";
break;
case "7":
cardsValue = "7";
break;
case "8":
cardsValue = "8";
break;
case "9":
cardsValue = "9";
break;
case "10":
cardsValue = "10";
break;
case "Валет":
cardsValue = "10";
break;
case "Дама":
cardsValue = "10";
break;
case "Король":
cardsValue = "10";
break;
case "Туз":
cardsValue = "11";
break;
}
return Convert.ToInt32(cardsValue);
}
void userMove ( string[] arr, int i)
{
 string userCard = cards[new Random().Next (0, cards.Length)];
 userCards[i] = userCard;
 userCardsMoveValue = Exchenge(userCard);
 userSum = userSum + userCardsMoveValue;
 //return userCards[i];
}
void compMove ( string[] arr, int i)
{
 string compCard = cards[new Random().Next (0, cards.Length)];
 compCards[j] = compCard;
 compCardsMoveValue = Exchenge(compCard);
 compSum = compSum + compCardsMoveValue;
 //return compCards[j];
}
void userResult (int sum)
{
    if (sum > 21) 
    {   Console.WriteLine("Сожалею, но Вы проиграли");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч"); 
    }
    else if (sum == 21) 
    {   Console.WriteLine("Поздравляю Вы победили!!!");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    else if (sum == compSum) 
    {   Console.WriteLine("На этот раз ничья");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    
    
}
void compResult (int sum)
{
    if (sum > 21) 
    {   Console.WriteLine("Сожалею, но проиграл я");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    else if (sum == 21) 
    {Console.WriteLine("Моя победа!!!");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч"); 
    }
    else if (sum == userSum) 
    {   Console.WriteLine("На этот раз ничья");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    
}
void result (int sum)
{
    if (sum> compSum) 
    {   Console.WriteLine("Поздравляю Вы оказались удачливее!!!");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    else if (sum < compSum) 
    {   Console.WriteLine("Победа моя!!!");
        Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
    else if (sum == compSum) 
    {
    Console.WriteLine("На этот раз ничья");
    Console.WriteLine("Возвращайтесь снова, до скорых встреч");
    } 
}
Console.Clear();
Console.WriteLine("Добрый день!");
Console.WriteLine("Представтесь пожалуйста ");
userName = Console.ReadLine();
Console.Clear();
Console.WriteLine( userName + " сегодня играем с тобой. Учти что я очень азартен!!!");
int move = 2;//new Random().Next(1, 3);
if (move %2 ==0){
    Console.WriteLine("Выпало " + move + " четное. Ваш ход " + userName);
    Console.WriteLine("У Вас на руках");
    for (i = 0; i < 2; i++){ 
        userMove(cards, i);
        Console.Write(userCards[j] + " | ");
    }
    Console.WriteLine ("Сумма очков у Вас- " + userSum);
    Console.WriteLine ("У меня на руках");
    for (j = 0; j < 2; j++){ 
        compMove(cards, j);
        Console.Write(compCards[j] + " | ");
    }
    Console.WriteLine ("Сумма очков у меня - " + compSum);
    if (userSum >= 21){ 
        userResult(userSum);
        goto end;
    }
    else if (compSum >= 21){ 
        compResult(compSum);
        goto end;
        }
    //i = 2;
    //j = 2;
    while(userSum <= 21){
        Console.WriteLine(userName + " берем еще?");
        string yesOrNo = Console.ReadLine();
        if (yesOrNo == "да"){
            Console.WriteLine("У Вас на руках");
            userMove(cards, i);
            for (int k = 0; k <= i; k++){    
                Console.Write(userCards[k] + " | ");
            }
            i++;
            Console.WriteLine (" у Вас сумма очков - " + userSum);
                if (userSum <=21){
                    Console.WriteLine ("У меня на руках");
                    compMove(cards, j);
                    for (int k = 0; k <= j; k++){ 
                        Console.Write(compCards[k] + " | ");
                    }
                Console.WriteLine ("Сумма очков у меня - " + compSum);
                j++;
                }
        }else{
            while (compSum <= 21){
                if (compSum < 21){
                    Console.WriteLine ("У меня на руках");
                    compMove(cards, j);
                        for (int k = 0; k <= j; k++){ 
                            Console.Write(compCards[k] + " | ");
                        }
                        Console.WriteLine("Сумма очков у меня - " + compSum);
                        j++;
                }
            }
        }
        Console.WriteLine();
        if (userSum >= 21){
            userResult(userSum);
            goto end;
        }
        else if (compSum >= 21){
            compResult(compSum);
            goto end;
        }
        else{ 
            result (userSum);
            goto end;
        }
    }
}
end:;


    /*Console.WriteLine("Выпало " + move + " четное. Ваш ход " + userName);
    Console.WriteLine("У Вас на руках");
    for (; i < 2; i++){ 
        userMove(cards);
        Console.Write(userCards[i] + " | ");
    }
    Console.WriteLine ("Сумма очков - " + userSum);
    Console.WriteLine ("У меня на руках");
    for (; j < 2; j++){ 
        compMove(cards);
        Console.Write(compCards[j] + " | ");
    }
    Console.WriteLine ("Сумма очков - " + compSum);
    if (userSum <= 21 || compSum <= 21){
        i = 2;
        j = 2;
        do{
            Console.WriteLine(userName + " берем еще?");
            string yesOrNo = Console.ReadLine();
                if (yesOrNo == "да"){
                    Console.WriteLine("У Вас на руках");
                        for (int k = 0; k < i; k++){ 
                            userMove(cards);
                            Console.Write(userCards[i] + " | ");
                        }
            Console.WriteLine (" у Вас сумма очков - " + userSum);
            i++;
                if (userSum <21){
                    Console.WriteLine ("У меня на руках");
                    for (int k = 2; k < j; k++){ 
                        compMove(cards);
                        Console.Write(compCards[j] + " | ");
                    }
                }    
            }do{
            Console.WriteLine ("У меня на руках");
                for (int k = 0; k < j; k++){ 
                    compMove(cards);
                    Console.Write(compCards[j] + " | ");
                }
            Console.WriteLine (" у меня сумма очков - " + compSum);
            j++;
           
            }while(compSum <= 21);
        }while(userSum <= 21 || compSum <= 21);
        
           
        
   
    }else if (compSum > 21){    
        userResult(userSum);
    }else compResult(compSum);


}





    



/*void userMove (int i)
{
int k = new Random().Next(0, cards.Length-1);
cardsUser[i] = cards[k];

}

void compMove (int i)
{
int k = new Random().Next(0, cards.Length-1);
cardsComp[i] = cards[k];
}
int userMoveS (int i)
{
cardsUser[i] = cards[u];
sumUser = sumUser + Exchenge(cards[u]);
return sumUser;
}
int compMoveS (int i)
{
cardsComp[i] = cards[c];
sumComp = sumComp + Exchenge(cards[c]);
return sumComp;
}
Console.WriteLine("Добрый день! Представтесь пожалуйста");
string userName = Console.ReadLine();
Console.WriteLine( userName + " cыграем в азартную игру? (1-да, 2-нет)");
string yesOrNo = Console.ReadLine();
if (yesOrNo == "1"){//Проверка на согласие играть
Console.WriteLine("Бросим жребий кто ходит первым? (1-да, 2-нет)");
string fart = Console.ReadLine();
Console.Clear();
    if (fart == "1"){//жеребьевка
        int move = 2;//new Random().Next(1, 3);
        if (move %2 ==0){//Первый ход ход игрока
            Console.WriteLine("Ваш первый ход, выпало " + move);
            Console.WriteLine();
            Console.WriteLine("У Вас ");
            
                for (int j = 0; j < 2; j++){
                    u = new Random().Next(0, cards.Length-1);
                    userMoveS(j);
                    Console.Write(cardsUser[j] + "|");
                }//выбор первых двух карт
            Console.WriteLine();
            Console.WriteLine("(Количество очков = " + sumUser + ")");
                if (sumUser == 21){//если 21 то победа
                    Console.WriteLine("Мои поздравления!!! Вы победили!!!");
                    goto end;
                }//если 21 то победа
                else if (sumUser > 21){//Проигрыш
                    Console.WriteLine("Сожалею но я победил");
                    goto end;
                }//Проигрыш
                else{//Меньше 21, ход компа
            Console.WriteLine("");
            Console.WriteLine("У меня ");
                for (int j = 0; j < 2; j++){
                    c = new Random().Next(0, cards.Length-1);
                    compMoveS(j);        
                    Console.Write(cardsComp[j] + "|");
                    }
                //выбор первых двух карт
            Console.WriteLine();
            Console.WriteLine("(Количество очков = " + sumComp + ")");
                if (sumComp == 21){//если 21 то победа
                    Console.WriteLine("У меня 21. Мои сожаления но победа моя");
                    goto end;
                }//если 21 то победа
                else if (sumComp > 21){//Проигрыш
                    Console.WriteLine("Мои поздравления!!! Вы победили!!! у меня " + sumComp + " это больше 21" );
                    goto end;
                }
                }
                i = 3;//Проигрыш
                do {
                Console.WriteLine();
                Console.WriteLine("Берем еще? (1-да, 2-нет)");
                int more = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                    if (more == 1){
                        Console.WriteLine();
                        Console.WriteLine("У Вас ");
                        u = new Random().Next(0, cards.Length-1);
                        userMoveS(i-1);                       
                            for (int j = 0; j < i; j++){
                                Console.Write(cardsUser[j] + " | ");
                            }
                Console.WriteLine("(Количество очков = " + sumUser + ")");
                    if (sumUser == 21){//если 21 то победа
                        Console.WriteLine("Мои поздравления!!! Вы победили!!!");
                        goto end;
                    }//если 21 то победа
                    else if (sumUser > 21){//Проигрыш
                        Console.WriteLine("Сожалею но я победил");
                        goto end;
                    }//Проигрыш
                    }else{
                        while (sumComp <= 21){
                            Console.WriteLine(); 
                            Console.WriteLine("У меня ");
                            c = new Random().Next(0, cards.Length-1);
                            compMoveS(i-1);
                            for (int j = 0; j < i; j++){
                                Console.Write(cardsComp[j] + " | ");
                            }
                        i++;
                        Console.WriteLine();       
                        Console.Write("(Количество очков = " + sumComp + ")");
                    if (sumComp > sumUser){
                    goto loos;   
                    }else if (sumComp < sumUser){
                    goto win;   
                    }else{
                    goto r;    
                    }
                    }
                    }
                    
                        //Меньше 21, ход компа
                    Console.WriteLine();
                    Console.WriteLine("У меня ");
                    c = new Random().Next(0, cards.Length-1);
                    compMoveS(i-1);
                        for (int j = 0; j < i; j++){
                            Console.Write(cardsComp[j] + " | ");
                        }
                    i++;
                    Console.WriteLine();       
                    Console.WriteLine("(Количество очков = " + sumComp + ")");
                    if (sumComp == 21){//если 21 то победа
                        Console.WriteLine();
                        Console.WriteLine("У меня 21. Мои сожаления но победа моя");
                        goto end;
                    }//если 21 то победа
                    else if (sumComp > 21){//Проигрыш компа
                        Console.WriteLine();
    
                        Console.WriteLine("Мои поздравления!!! Вы победили!!! у меня " + sumComp + " это больше 21" );
                        goto end;
                    }
                    
                    
            }while (sumUser <= 21 || sumComp <= 21);
              
        }
    }   
}
win:
Console.WriteLine();
Console.WriteLine("Мои поздравления!!! Вы победили!!!");
r:
Console.WriteLine("На этот раз ничья");
loos:
Console.WriteLine();
Console.WriteLine("Победа моя!");
end:
Console.WriteLine();
Console.WriteLine("Благодарю за игру !");





















   }else{
    Первым ходит комп







    }
}else{//Проверка на согласие играть
Console.WriteLine("Ну что же, в другой раз сыграем обязательно!!!");
Console.WriteLine("До скорых встреч"); 
}*/












