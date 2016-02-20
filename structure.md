Based on: https://gist.github.com/davidfowl/ed7564297c61fe9ab814

```
$/
  docs/
  src/
  tools/
  tests/
  samples/
  artifacts/
  packages/
  build/
  lib/
  .editorconfig
  .gitignore
  .gitattributes
  NuGet.config
  global.json
  {solution}.sln
  README.md
  LICENSE
```


- `src` - Main projects (the product code)
- `tools` - Tools that generate code, etc.
- `tests` - Test projects
- `docs` - Documentation stuff, markdown files, help files etc.
- `samples` (optional) - Sample projects
- `lib` - Things that can **NEVER** exist in a nuget package
- `artifacts` - Build outputs go here. Doing a build.cmd/build.sh generates artifacts here (nupkgs, dlls, pdbs, etc.)
- `packages` - NuGet packages
- `build` - Build customizations (custom msbuild files/psake/fake/albacore/etc) scripts
- `global.json` - ASP.NET vNext only