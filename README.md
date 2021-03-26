# ASP_inlamning1

# ASP.NET Core och dess användningsområde:
Asp.net core är ett framework för att bygga hemsidor med alla delar som man behöver samlat i ett projekt. 
Du bygger och programerar servern som har hand om hemsidan samt kopplar ihop en databas till servern. 
Program.cs: Här startar programmet, den gör en host genom metoden createHostBuilder där man också har möjlighet att ställa in hur hosten ska arbeta, inställningar osv. 
Inställningar och hur servern ska arbeta sker i Startup.cs. Det flesta sköts via AddRazorPages som ligger under ConfigureService metoden. Här har vi även sagt till att servern ska 
använda sig av en databas. Det finns ockspå en metod som heter configure inne i startup. Den sköter alla middlewares, tex på en middleware är app.UseHttpsRedirection som ser till 
att det alltid är en https som används även om användaren skriver in http bara. 
Det finns också en mapp med statiska filer: wwwroot som inehåller tex css filer och javascript även bilder och liknande. Här är filer som servern inte ändrar något på när användaren vill hämta hem en fil eller om css/javascript används på en sida.


# Razor Pages:
Razor pages är en blandning av HTML och c#. Den inehåller en ren c# fil kallad model filen (Index.cshtml.cs) och en fil med razor kod som är html tillsamans med lite c# kod (Index.cshtml). Tanken här är 
att man ska ha all funktionalitet i den rena c# filen(modelen) och sedan i razor filen har man designen/layoten/view. Så en razor page består enkelt av en VIEW fil och en MODEL fil som tillsamans hör ihop. 

# MVC : 
MVC består istället av tre filer. Model, View och Controller. Här hänger inte sambandet ihop lika tydligt mellan model och view som i razor page, istället finns det en controller som sköter vilka views som ska styras av vilka modeller och när osv. Alltså om två views behöver samma modell kan controllen skicka en model till båda sidor istället för som i razor pages att man har då två modeller, en till varje sida. (Har inte jobbat med MVC men det är så jag fattat det som)


