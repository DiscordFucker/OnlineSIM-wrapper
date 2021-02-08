# OnlineSIM
An OnlineSIM API Wrapper

# Documentation

## Namespace

```cs
using OnlineSIM; //Import OnlineSIM namespace
```

## Class

```cs
OnlineSimClient client = new OnlineSimClient("API KEY"); 
```

## Methods

### Account Info
```cs
string balance = [Class].GetBalance(); // return money in the balance
```

```cs
string zbalance = [Class].GetZBalance(); // return money in the ZBalance
```

### [Number]()
```cs
string tzid = [Class].CreateTZID(discord, 7); // Create TZID (really important) & return TZID
```

```cs
string number = [Class].GetNumber(tzid); // return created phone number
```

```cs
string code = [Class].GetReceivedCode(tzid) // return received code
```

# Phone Number infos

| Alias1  | Alias2 | Service |
|----|---|----|
| VKcom | vk | Вконтакте |
| 3223 | facebook | Facebook |
| MailRu | mailru | MailRu |
| Odklru | classmates | Одноклассники |
| Google | gmail | GMail |
| Yandex | yandex | Yandex |
| Avito | avito | Avito |
| Youla | youla | Youla |
| Viber | viber | Viber |
| WhatsApp | whatsapp | WhatsApp |
| Telegram | telegram | Telegram |
| FastFriend | drugvokrug | ДругВокруг |
| Instagram | instagram | Instagram |
| WeChat | wechat | WeChat |
| Steam | steam | Steam |
| Uber | uber | Uber |
| Microsoft | microsoft | Microsoft |
