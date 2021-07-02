var num = parseInt(window.prompt("Digite:"));
var notacem = 0,notacinquenta = 0,notavinte = 0,notadez = 0,notacinco = 0,notadois = 0,notaum = 0;
while(num != notaum)
{
  if(num >= 100)
  {
    num /= 100; 
    notacem++;
  }
  if(num >= 50 && num < 100)
  {
    num /= 50;
    notacinquenta++;
  }
  if(num >= 20 && num < 50)
  {
    num /= 20;
    notavinte++;
  }
  if(num >= 10 && num < 20)
  {
    num /= 10;
    notadez++;
  }
  if(num >= 5 && num < 10)
  {
    num /= 5;
    notacinco++;
  }
  if(num >= 2 && num < 5)
  {
    num /= 2;
    notadois++;
  }
  if(num >= 1)
  {
    notaum = num/1;
  }
}
window.alert(`${notacem} nota(s) de R$ 100,00\n ${notacinquenta}nota(s) de R$ 50,00\n ${notavinte}nota(s) de R$ 20,00\n ${notadez} nota(s) de R$ 10,00\n${notacinco}nota(s) de R$ 5,00\n ${notadois}nota(s) de R$ 2,00\n${notaum}nota(s) de R$ 1,00`);
