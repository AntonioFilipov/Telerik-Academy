# Singleton Pattern
___

## ��� �� ������� �� ������:
Singleton Pattern

## ������ ��������:
�������� �� ������ "Singleton" ������� ����-���������� ��������� �� ����� ����.

## ��������:
����� ���� ������ �� ������ � ��������� �� ������, ����� ������ �� �������� �������� ������ � ������������� �� ����-���������� ��������� �� ����� � ����������.

## ���� �� ��������:
1/5

## UML ������� ��������:
![Singleton UML Class Diagram](http://download.codeplex.com/download?ProjectName=csharpdesignpatterns&DownloadId=244664 "Singleton UML Class Diagram")

## �������� ���������
+ ����������� ��������� ������������� �� ������� �� ������ "Singleton". ��� �� �� ����� �� ���-���������� �� ��� �� ��������� �� ����������� ��� ������������ ������������.
+ ����� � �� �� ��������, �� ��� ������� ������ ������������ ����������� � ��������� ���� ������ � ��������� �� ���� �� ���� ����������� �����. ����� ���� ��� � �������� ���� sealed, ����� ��������, �� �� ���� �� ���� ����������.
+ �������� �������������� ����� � ������� � ������ �������� ����������. ������ �� ���������� �������� �������� GetInstance � �� ������� ������ �� ���� �����. �� ������� ������ ��������, ����� ��������� ��������� �� ����-���������� ���������.
+ �� ����������� �� ������������� ��������� � ��������� ������ �� ����������, ����� ���������, �� ����-���������� ����� �� ������� ���� null ���������� � �� ���� ��������� ���� ���������, ��� �� �� ���������� ����.
+ ������� � ����� DisplayConfiguration(), ����� ���� � ������� �������� ������ ������.

```cs
	public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static object syncRoot = new Object();
 
        private ConfigurationManager() 
        { 
        
        }
 
        public static ConfigurationManager GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
 
                return instance;
            }
        }
 
        public void DisplayConfiguration()
        {
            Console.WriteLine("Single instance object");
        }
    }
```

+ ��� ������� ������ ������������ ����������� ������ � ��������� ���� ������, ���� �� �������������� �� ������ ����� � ����������.  ����� ���� ��� � �������� ���� sealed, ����� ��������, �� �� ���� �� ���� ����������.
+ ���� ��� � ��������� ������ nested ����, ����� ������ �� ������� ������ �����������, ����� �� ���� ������ ������ �� ���� ����-���������� � ������ ����������.
+ ���� nested ���� ��������� �������� ���������� ����������� � �������� internal read-only ��������� �� ������. ���� ��������� ������ �� ������ ��� ������ �� ���� ��������� (����������� ����������� � �������� ���� read-only).
+ ������� � ����� DisplayRules(), ����� ���� � ������� �������� ������ ������.
+ ���� ������ � ��������������, ������ ���� ���������� � � �������� �� ��������� �� ������������������.

```cs
    public sealed class BusinessRulesManager
    {
        private BusinessRulesManager()
        {
 
        }
 
        public static BusinessRulesManager GetInstance
        {
            get
            {
                return BusinessRulesManagerImpl.instance;
            }
        }
 
        public void DisplayRules()
        {
            Console.WriteLine("Single instance object");
        }
 
        private class BusinessRulesManagerImpl
        {
            static BusinessRulesManagerImpl()
            {
 
            }
 
            internal static readonly BusinessRulesManager instance = new BusinessRulesManager();
        }
    }
```

+ ��� ���������� ������ �������� ����� ���, �� �� �������� ������� � ������ ������������� �� �������.

```cs
	private static void Singleton()
    {
        var configurationManager = ConfigurationManager.GetInstance;
        configurationManager.DisplayConfiguration();
 
        var businessRulesManager = BusinessRulesManager.GetInstance;
        businessRulesManager.DisplayRules();
 
        Console.ReadKey();
    }
```