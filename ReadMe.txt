1- Proye ve proje katmanlar� olu�turulur.
2- EntityLayer katman�na concrete klas�r� eklenir ve i�erisine s�n�flar yaz�l�r
3- Datalayer katman�na context klas�r� eklenir ve ApplicationDbContext s�n�f� olu�turulur. Burada EF paketi ve SqlServer paketi eklenir.
4- LibraryUI katman�nda Autofac paketi kurulur ve dependency injection i�lemleri i�in repositoryler burada tan�mlan�r.
5- XtraHome.cs i�erisinde dependency injection i�lemleri tan�mlan�r.
