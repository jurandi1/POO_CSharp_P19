Introdução aos Generics

Generics:

• Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. 

Seus benefícios são: 

• Reuso

• Type safety

• Performance

• Uso comum: coleções


List<string> list = new List<string>();
list.Add("Maria");
string name = list[0];
