# Совместимость старого тренажёра

Start_LRn.cmd запускает исходный EXE с русской кодовой страницей только для этого процесса. Глобальные настройки Windows не меняются. Установка, обновление и регистрация компонентов не выполняются. Собственный PortableLocaleHost.cs вызывает LoaderWrapper.Start из LEProc; исходный код оболочки приложен. В зависимости от политики компьютера запуск старого приложения может быть ограничен.

Использованы неизменённые библиотеки официального Locale Emulator 2.5.0.1: LEProc.exe, LECommonLibrary.dll, LoaderDll.dll, LocaleEmulator.dll. LECommonLibrary.dll извлечена из ресурса официального LEInstaller.exe. Файлы COPYING и COPYING.LESSER сохранены вместе с библиотеками. Проекты распространяются по GNU LGPL v3; исходники и сведения об авторах доступны по ссылкам ниже.

Релиз: https://github.com/xupefei/Locale-Emulator/releases/tag/v2.5.0.1
Архив релиза: https://github.com/xupefei/Locale-Emulator/releases/download/v2.5.0.1/Locale.Emulator.2.5.0.1.zip
SHA256 архива: 808ff584426d52cc775ad6406da00622f454be95bd4c8fbca42eef4b7235ad5c
Исходники интерфейса: https://github.com/xupefei/Locale-Emulator/tree/v2.5.0.1
Исходники ядра: https://github.com/xupefei/Locale-Emulator-Core

Тренажёр является предоставленным учебным ПО; его EXE не изменён. В комплекте сохранена исходная методичка.
