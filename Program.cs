string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз"};
int i=1, sum=0;
string cardsValue = "";
int card;
string exchenge(string cards)
{
switch (cards)
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
Console.WriteLine("Добрый день! Представтесь пожалуйста");
string userName = Console.ReadLine();
Console.WriteLine( userName + " cыграем в азартную игру? (1-да, 2-нет)");
string yesOrNo = Console.ReadLine();
if (yesOrNo == "1"){//Проверка на согласие играть
Console.WriteLine("Бросим жребий кто ходит первым? (1-да, 2-нет)");
string fart = Console.ReadLine();
if (fart == "1"){//жеребьевка
int move = 2;//new Random().Next(1, 3);
if (move %2 ==0){//Первый ход ход игрока
Console.WriteLine("Ваш первый ход, выпало " + move);
Console.WriteLine("У Вас ");
    for (i = 0; i<=1; i++){//выбор первых двух карт игрока
        int j = new Random().Next(0, cards.Length);
        card = Convert.ToInt32(exchenge(cards[j]));
        Console.Write(cards[j] + " ");
        sum = sum + card;
    }//выбор первых двух карт
Console.Write("(Количество очков = " + sum + ")");
    

}//Первый ход ход игрока

}//жеребьевка
}else{//Проверка на согласие играть
Console.WriteLine("Ну что же, в другой раз сыграем обязательно!!!");
Console.WriteLine("До скорых встреч"); 
}