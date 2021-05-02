Web-api для взаимодействия с базой данных PostgreSq gamesdb, в которой хранятся данные о видеоиграх.
Информация о игре: название, студия разработчик, несколько жанров, которым соответствует игра.

Api для работы:

 - api/games/read - прочитать всю базу данных
 - api/games/read/{value} - получить все игры, у которых есть жанр value
 - api/games/create?name={}&author={}&genres={} - добавить запись в базу 
 - api/games/delete/{id} - удалить из базы запись с id
 - api/games/update/name/{id}?name={} - изменить у записи с id значение поля name 
 - api/games/update/author/{id}?author={} - изменить у записи с id значение поля author 
 - api/games/update/genres/{id}?genres={} - изменить у записи с id значение поля genres 
