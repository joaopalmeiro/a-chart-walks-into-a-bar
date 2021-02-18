# ScottPlot

- [Website](https://swharden.com/scottplot/).
- [Repo](https://github.com/scottplot/scottplot).

## Notes

- Create the app: `dotnet new console`.
- Run the app: `dotnet run`.
- Install [`mono-libgdiplus`](https://formulae.brew.sh/formula/mono-libgdiplus) (macOS): `brew install mono-libgdiplus`.
- `.gitignore`: `dotnet new gitignore`.
- [Documentation](https://swharden.com/scottplot/cookbooks/4.0.47/).
- `Fontconfig warning: ignoring UTF-8: not a valid region tag`: `export LC_CTYPE="en_US.UTF-8"`.
- [`dotnet-format`](https://github.com/dotnet/format):
  - Install: `dotnet tool install -g dotnet-format`.
  - Run: `dotnet format`.

## References

- [Tutorial: Create a .NET console application using Visual Studio Code](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code).
- [Quickstart: Install and use a package using the dotnet CLI](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli).
- Rafal Pienkowski's "[Easy to create .gitignore for the dotnet developers](https://dev.to/rafalpienkowski/easy-to-create-gitignore-for-the-dotnet-developers-1h42)" blog post.
- [How to serialize and deserialize (marshal and unmarshal) JSON in .NET](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to).
- [How to customize property names and values with System.Text.Json](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-customize-properties).
