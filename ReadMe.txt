1- Proye ve proje katmanlarý oluþturulur.
2- EntityLayer katmanýna concrete klasörü eklenir ve içerisine sýnýflar yazýlýr
3- Datalayer katmanýna context klasörü eklenir ve ApplicationDbContext sýnýfý oluþturulur. Burada EF paketi ve SqlServer paketi eklenir.
4- LibraryUI katmanýnda Autofac paketi kurulur ve dependency injection iþlemleri için repositoryler burada tanýmlanýr.
5- XtraHome.cs içerisinde dependency injection iþlemleri tanýmlanýr.
