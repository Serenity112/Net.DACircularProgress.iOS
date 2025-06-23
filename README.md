Проект основан на библиотеке Daniel Amitay под MIT лицензией.

#### Особенности обёртки

Библиотека не поставляется как .xcframework, так как ей 10+ лет. Она состоит из 4 файлов, поэтому было принято решение просто скопировать исходники и на основании них сделать .xcframework + проект-обёртку. Обновляться она не будет, поэтому способ приемлемый.


#### Способ подключения

Скачиваем архив из Releases на Github, он будет содержать .dll файл + .resources файл который содержит .xcframework. Кладём эти файлы в папку проекта, например Library, и подключаем к .NET iOS проект как зависимость.
Структура:
`Library/iOS/Net.DACircularProgress.iOS.dll`
`Library/iOS/Net.DACircularProgress.iOS.resources`

`<ItemGroup>`  
    `<Reference Include="Net.DACircularProgress.iOS">`  
        `<HintPath>..\Library\iOS\Net.DACircularProgress.iOS.dll</HintPath>`  
    `</Reference>`  
`</ItemGroup>`


#### Пример использования:

`var progressView = new DACircularProgressView((new CGRect(...)));`
`progressView.ProgressTintColor = UIColor.Red;`  
`progressView.TrackTintColor = UIColor.Green;`  
`progressView.ThicknessRatio = (nfloat)0.25;`
`View.AddSubview(ProgressView);`

`progressView.Progress = 0.5f`

Свойство `Progress` устанавливаем в цикле/привязкой в зависимости от способа использования


#### Сборка (опционально)

Если необходимо пересобрать библиотеку заново, то для этого есть 2 скрипта, которые лежат в папке Native/DACircularProgress
- generation.sh
Это скрипт для генерации .xcframework файла. Он собирает библиотеку для девайса/эмулятора и помещает результирующий .xcframework в папку xcframeworks/DACircularProgress.xcframework
- binding.sh
Это скрипт для герерации c# обертки для вызова нативных методов. Он использует утилиту objective sharpie, и iOS sdk18.2. Если утилиты нет - можно скачать через `homebrew`. iOS sdk можно использовать и другой, но например 18.4 у меня ломанный и привязка не генерировалась.
Как из этого всего сделать библиотеку привязки - https://learn.microsoft.com/en-us/previous-versions/xamarin/ios/platform/binding-objective-c/walkthrough?tabs=windows