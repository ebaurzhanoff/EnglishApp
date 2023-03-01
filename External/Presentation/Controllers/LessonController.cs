using Domain.LessonBoundaryModel;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonController : ControllerBase
{
    [HttpGet]
    public Lesson Get(long id)
    {
        var lesson = new Lesson
        {
            Id = id,
            Title = "Lesson 1",
            Description = "Description 1"
        };

        return lesson;
    }

    [HttpPost]
    public IActionResult Post(Request request)
    {
        return Ok(request);
    }
}

public class Request
{
    public string Name { get; set; }
}


// Создать github аккаунт
// Скачать git и установить  (Далее)
// Создать класс Animal и методы свойста и поля
// Унаследовать Animal класс у Dog
// Создать объект и вызвать методы
// Максимально прочитать метанит
// Внутри объекта Анимал в методах (функциях) прописать логику работы с данными (входящие параметры)


// Open Git Bach
// git config --global user.name "Ernur Bauyrzhan"
// git config --global user.email "ernurbauyrzhan@gmail.com"

// Open VS 2022 ->  Clone Repository -> https://github.com/ebaurzhanoff/EnglishApp.git
