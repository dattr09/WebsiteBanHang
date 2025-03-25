dotnet ef migrations add InitialCreate
dotnet ef database update
https://websitebanhang-5aqv.onrender.com 2. Nhập dữ liệu trên Mac (Máy Mới)
Sau khi clone project về Mac, bạn cần chạy lại database bằng Docker.

2.1 Chạy SQL Server trên Docker
Mở Terminal và chạy lệnh:

<!-- docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" \
-p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:latest -->

Lệnh này sẽ chạy SQL Server trên Docker.

2.2 Áp dụng Migration
Trước khi chạy migration, bạn cần đảm bảo chuỗi kết nối trong appsettings.json của bạn trỏ đúng đến SQL Server trên Docker:

<!-- "ConnectionStrings": {
"DefaultConnection": "Server=localhost,1433;Database=YourDB;User Id=sa;Password=YourStrong!Passw0rd;"
} -->

Sau đó, chạy các lệnh sau để áp dụng migration:

<!-- dotnet ef database update
Lệnh này sẽ chạy Migration để tạo lại database. -->

2.3 Nhập dữ liệu từ File SQL
Nếu bạn đã xuất dữ liệu bằng migrations.sql, chạy lệnh sau để nhập vào SQL Server trên Docker:

<!-- docker cp migrations.sql sqlserver:/migrations.sql
docker exec -it sqlserver /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'YourStrong!Passw0rd' -d YourDB -i /migrations.sql -->

Sau khi hoàn thành, bạn có thể kết nối với SQL Server bằng Azure Data Studio hoặc DBeaver trên Mac để kiểm tra dữ liệu.
