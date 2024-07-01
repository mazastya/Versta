# Versta
Web-приложение. Тестовое задание.

# Как запустить проект
1. Скачать проект
2. Подключиться к MS SQL Server
3. Создать базу данных
4. Запустить скрипт, который находится ниже

CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CitySender] [nvarchar](100) NOT NULL,
	[AddressSender] [nvarchar](400) NOT NULL,
	[CityRecipient] [nvarchar](100) NOT NULL,
	[AddressRecipient] [nvarchar](400) NOT NULL,
	[Weight] [float] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

5. Изменить строку подключения в файле appsettings.json на свой сервер и базу данных
6. Запустить проект

# Технологии
Для создания данного приложения были использованны:
- ASP.NET 8
- ASP.NET MVC
- Entity Framework Core
- Sql Server
  


