// Заменить все пробелы на | букву к на К буквы С на с
string text = "Провозглашение Прусского королевства. Участие в Северной войне. Правление Фридриха II. Война за австрийское наследство, Семилетняя война и принятие российского подданства. Освобождение жителей Кёнигсберга от присяги России и возвращение Восточной Пруссии Фридриху II. Наполеон посещает Кёнигсберг. Русские войска входят в Кёнигсберг, преследуя отступающих французов. Объединение Германии.";

string Replace(string text, char oldChar, char newChar){
    string result = String.Empty;
for(int i = 0; i < text.Length; i++){
    if(text[i] == oldChar) result += newChar;
    else result += text[i];
} 
return result;
}

Console.WriteLine(text);
Console.WriteLine();
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);