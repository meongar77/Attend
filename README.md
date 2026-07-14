# Attend
Attend is a software used by the schools to monitor students attendace. This is for training and educational purpose

Git initialization Steps

1. git init
2. git add .
3. git status
4. git remote add origin https://github.com/meongar77/Attend.git
5. git config --global user.email "meongar77@gmail.com"
6. git config --global user.name "Garou Simeon"
7. git commit -m "Initial commit"
8. git pull origin main --allow-unrelated-histories
9. git push origin main



Entity framework
1. dotnet tool install --global dotnet-ef --version 10.0.0
2. dotnet ef migrations add InitialMigration --project ../Infrastructure/Infrastructure.csproj --startup-project ../Web/Web.csproj (For Every migration you change the name of file)
3. dotnet ef database update --project ../Infrastructure/Infrastructure.csproj --startup-project ../Web/Web.csproj