# Validador de Paréntesis Balanceados

Aplicación web en ASP.NET MVC que verifica si los símbolos `()`, `[]` y `{}` están balanceados en una cadena.  
**Incluye:**  
✅ Persistencia en SQL Server LocalDB  
✅ Historial de validaciones  

## Cómo Ejecutarlo
1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/tu-usuario/ValidadorParentesisBalanceados.git
   ```
2. **Abre la solución** en Visual Studio (archivo `.sln`).
3. **Restaura paquetes NuGet**: Click derecho en la solución → *Restore NuGet Packages*.
4. **Ejecuta migraciones** (en Package Manager Console):
   ```bash
   Update-Database
   ```
6. **En caso de error al compilar la aplicacion correr el siguiente comando: Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
   En la siguiente liga se podra encontrar la solucion al error mencionado: https://stackoverflow.com/questions/32780315/could-not-find-a-part-of-the-path-bin-roslyn-csc-exe

7. **Inicia la aplicación** (F5).

## Pruebas Básicas
| Cadena      | Resultado Esperado |
|-------------|--------------------|
| `{[()]}`    | Válido             |
| `([)]`      | Inválido           |
| `{`         | Inválido           |

## Estructura Principal
```plaintext
Controllers/   # Lógica de navegación (HomeController)
Models/        # Clases y contexto de base de datos
Services/      # Algoritmo de validación
Views/         # Interfaz (Index.cshtml)
```

## Tecnologías Usadas
- ASP.NET MVC (.NET Framework 4.7.2)
- Entity Framework 6
- SQL Server LocalDB
- Bootstrap (para estilos)

---

**Contacto:** jair172000@gmail.com
