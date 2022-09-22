string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз"};
string[] cardsUser = new string [20];
string[] cardsComp = new string [20];
int sumUser = 0, sumComp = 0, i = 0, cardsMoveValue = 0, numbCards = 0;
string cardsValue = "";
string Exchenge(string card)
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
return cardsValue;
}
int MoveValue (string[] card)
{
int result = Convert.ToInt32(Exchenge(cards[numbCards]));
return result;
}
Console.WriteLine("Добрый день! Представтесь пожалуйста");
string userName = Console.ReadLine();
Console.WriteLine( userName + " cыграем в азартную игру? (1-да, 2-нет)");
string yesOrNo = Console.ReadLine();
if (yesOrNo == "1"){//Проверка на согласие играть
Console.WriteLine("Бросим жребий кто ходит первым? (1-да, 2-нет)");
string fart = Console.ReadLine();
    if (fart == "1"){//жеребьевка
        Console.WriteLine("Бросим жребий кто ходит первым? (1-да, 2-нет)");
        int move = 2;//new Random().Next(1, 3);
        if (move %2 ==0){//Первый ход ход игрока
            Console.WriteLine("Ваш первый ход, выпало " + move);
            Console.WriteLine();
            Console.WriteLine("У Вас ");
                for (int j = 0; j<=1; j++){//выбор первых двух карт игрока
                    numbCards = new Random().Next(0, cards.Length-1);
                    cardsUser[j] = cards[numbCards];
                    sumUser = sumUser + Convert.ToInt32(MoveValue(cards));
                    Console.Write(cardsUser[j] + " | ");
                    i++;        
                }//выбор первых двух карт
            Console.WriteLine();
            Console.WriteLine("(Количество очков = " + sumUser + ")");
                if (sumUser == 21){//если 21 то победа
                    Console.WriteLine("Мои поздравления!!! Вы победили!!!");
                }//если 21 то победа
                else if (sumUser > 21){//Проигрыш
                    Console.WriteLine("Сожалею но я победил");
                }//Проигрыш
                else{//Меньше 21, ход компа
            Console.WriteLine("");
            Console.WriteLine("У меня ");
                }
                for (int j = 0; j<=1; j++){//выбор первых двух карт игрока
                    numbCards = new Random().Next(0, cards.Length-1);
                    cardsComp[j] = cards[numbCards];
                    sumComp = sumComp + Convert.ToInt32(MoveValue(cards));
                    Console.Write(cardsComp[j] + " | ");
                }//выбор первых двух карт
            Console.Write("(Количество очков = " + sumComp + ")");
                if (sumComp == 21){//если 21 то победа
                    Console.WriteLine("У меня 21. Мои сожаления но победа моя");
                }//если 21 то победа
                else if (sumComp > 21){//Проигрыш
                    Console.WriteLine("Мои поздравления!!! Вы победили!!! у меня " + sumComp + " это больше 21" );
                }//Проигрыш
            do {
            Console.WriteLine();
            Console.WriteLine("Берем еще? (1-да, 2-нет)");
            int more = Convert.ToInt32(Console.ReadLine());
                if (more == 1){
                    Console.WriteLine();
                    Console.WriteLine("У Вас ");
                    numbCards = new Random().Next(0, cards.Length-1);
                    cardsUser[i] = cards[numbCards];
                    sumUser = sumUser + Convert.ToInt32(MoveValue(cards));
                        for (int j = 0; j <= i; j++){
                            Console.Write(cardsUser[j] + " | ");
                        }
            Console.WriteLine("(Количество очков = " + sumUser + ")");
                if (sumUser == 21){//если 21 то победа
                    Console.WriteLine("Мои поздравления!!! Вы победили!!!");
                }//если 21 то победа
                else if (sumUser > 21){//Проигрыш
                    Console.WriteLine("Сожалею но я победил");
                }//Проигрыш
                }else{//Меньше 21, ход компа
                Console.WriteLine();
                Console.WriteLine("У меня ");
                numbCards = new Random().Next(0, cards.Length-1);
                cardsComp[i] = cards[numbCards];
                sumComp = sumComp + Convert.ToInt32(MoveValue(cards));
                    for (int j = 0; j <= i; j++){
                        Console.Write(cardsComp[j] + " | ");
                    }
                    i++;       
                Console.Write("(Количество очков = " + sumComp + ")");
                    if (sumComp == 21){//если 21 то победа
                        Console.WriteLine();
                        Console.WriteLine("У меня 21. Мои сожаления но победа моя");
                    }//если 21 то победа
                    else if (sumComp > 21){//Проигрыш компа
                        Console.WriteLine("Мои поздравления!!! Вы победили!!! у меня " + sumComp + " это больше 21" );
                    }
                }
            }while (sumUser <= 21 || sumComp <= 21);      
        }
    }   
}




















   /* }else{
    Первым ходит комп







    }
}else{//Проверка на согласие играть
Console.WriteLine("Ну что же, в другой раз сыграем обязательно!!!");
Console.WriteLine("До скорых встреч"); 
}*/













/*


    Console.WriteLine();
    Console.WriteLine("У меня ");
     i = new Random().Next(0, cards.Length-1);
    cardsComp[i] = cards[i];
    cardsMoveValue = MoveValue(cards);
    sumComp = sumComp + Convert.ToInt32(cardsMoveValue);
    for (int j = 0; j <= i; j++){
    Console.Write(cardsComp[j] + " | ");
    }       
    Console.Write("(Количество очков = " + sumComp + ")");
    if (sumComp == 21){//если 21 то победа
    Console.WriteLine();
    Console.WriteLine("У меня 21. Мои сожаления но победа моя");
    }//если 21 то победа
    else if (sumComp > 21){//Проигрыш компа
        Console.WriteLine("Мои поздравления!!! Вы победили!!! у меня " + sumComp + " это больше 21" );
    }//Проигрыш компа
    }}


//Первый ход ход игрока
}}}else{//Первый ход компа

//Первый ход компа
//жеребьевка
else{//Проверка на согласие играть
Console.WriteLine("Ну что же, в другой раз сыграем обязательно!!!");
Console.WriteLine("До скорых встреч"); 
}}*/