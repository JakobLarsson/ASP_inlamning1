# ASP_inlamning1

ASP.NET Core och dess användningsområde: Asp.net core är ett framework för att bygga hemsidor med alla delar som man behöver samlat i ett projekt. 
Du bygger och programerar servern som har hand om hemsidan samt kopplar ihop en databas till servern. 
Program.cs: Här startar programmet, den gör en host genom metoden createHostBuilder där man också har möjlighet att ställa in hur hosten ska arbeta, inställningar osv. 
Inställningar och hur servern ska arbeta sker i Startup.cs. Det flesta sköts via AddRazorPages som ligger under ConfigureService metoden. Här har vi även sagt till att servern ska 
använda sig av en databas. Det finns ockspå en metod som heter configure inne i startup. Den sköter alla middlewares, tex på en middleware är app.UseHttpsRedirection som ser till 
att det alltid är en https som används även om användaren skriver in http bara. 

