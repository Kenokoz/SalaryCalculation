#  Salary calculation for Employees
В репозитории находится консольное приложение, которое позволяет вести учет отработанного времени сотрудников и рассчитывать зарплату. 
С помощью него можно строить отчет по времени и зарплате по всем сотрудникам. 

### How it works
- в папке Lists находятся текстовые файлы, которые хранят информацию о сотрудниках и отчетах
- используются три вида ролей: руководитель (header), сотрудник на зарплате (employee), внештатный сотрудник (freelancer).

#### Header

1. Может добавлять сотрудников с ролью руководитель, сотрудник на зарплате, внештатный сотрудник 
2. Может добавлять время любому сотруднику. Возможно добавление времени задним числом.
3. Может просматривать отчет за выбранный период по всем сотрудникам (периоды могут быть за день, за неделю, за месяц)
4. Может просматривать часы работы за выбранный период по конкретному сотруднику 

#### Employee

1. Может добавлять отработанные часы в список сотрудников. 
   Добавлять время может только за себя. Возможно добавление времени задним числом.
2. Может просматривать свои отработанные часы и зарплату за период

#### Freelancer

1. Может добавлять отработанные часы в список внештатных сотрудников.
   Добавлять время может только за себя. 
   Возможно добавление времени задним числом не ранее чем за два дня от текущего времени.
2. Может просматривать свои отработанные часы и зарплату за период

