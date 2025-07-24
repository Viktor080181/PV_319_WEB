// JavaScript source code
let check = document.getElementById("check");
check.innerHTML = "Hello DOM";
console.log(check.outerHTML);

//append(element);  //Добавляет element в конец ноды, а именно, перед закрывающим дескриптором;
//prepend(element); //Добавляет element в начало ноды, а именно, после открывающего дескриптора;
//before(element);  //Добавляет element перед открывающим дескриптором;
//after(element);   //Добавляет элемент после закрывающего дескриптора;

//Node - это узел дерева.

let configuration = document.getElementById("configuration");
configuration.append("append();");
configuration.prepend("prepend();");
configuration.before("<h2>Добавление элементов к ноде</h2>");
configuration.after("Вот и сказочке конец");