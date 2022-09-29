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
int move = 1;//new Random().Next(1, 3);
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
    while(compSum <18){
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
            if (compSum < 20){
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
}else{
    Console.WriteLine("Выпало " + move + " не четное. Мой ход");
    Console.WriteLine ("У меня на руках");
        for (j = 0; j < 2; j++){ 
            compMove(cards, j);
            Console.Write(compCards[j] + " | ");
            }
        j++;
        Console.WriteLine ("Сумма очков у меня - " + compSum);
        Console.WriteLine("У Вас на руках");
        for (i = 0; i < 2; i++){ 
            userMove(cards, i);
            Console.Write(userCards[i] + " | ");
        }
        Console.WriteLine ("Сумма очков у Вас - " + compSum);
        i++;
    while (compSum <=18){
        Console.WriteLine();
        Console.WriteLine ("У меня на руках");
        compMove(cards, j);
            for (int k = 0; k <= j; k++){ 
                Console.Write(compCards[k] + " | ");
                }
        Console.WriteLine ("Сумма очков у меня - " + compSum);
        j++;
    }
    if (compSum <=21){
    Console.WriteLine(userName + " берем еще?");
    string yesOrNo = Console.ReadLine();
        if (yesOrNo == "да"){
        Console.WriteLine("У Вас на руках");
            userMove(cards, i);
            for (int k = 0; k <= i; k++){    
                Console.Write(userCards[k] + " | ");
            }
            i++;
        Console.WriteLine ("Сумма очков у меня - " + compSum);
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
end:;
