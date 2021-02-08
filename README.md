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

VKcom | vk | Вконтакте | OK
facebook | Facebook | OK
MailRu | mailru | MailRu | 
Odklru | classmates | Одноклассники | 
Google | gmail | GMail | OK
Yandex | yandex | Yandex | OK
Avito | avito | Avito | 
Youla | youla | Youla | OK
Viber | viber | Viber | OK
WhatsApp | whatsapp | WhatsApp | OK
Telegram | telegram | Telegram | OK
FastFriend | drugvokrug | ДругВокруг | 
Instagram | instagram | Instagram | OK
WeChat | wechat | WeChat | OK
Steam | steam | Steam | OK
Uber | uber | Uber | OK
Microsoft | microsoft | Microsoft | OK
