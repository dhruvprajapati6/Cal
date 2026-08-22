# 🚀 How to Release Your Calculator

## Quick Release Process (3 commands):

```bash
# 1. Commit your changes
git add .
git commit -m "Calculator v1.0.0"

# 2. Create a tag
git tag v1.0.0

# 3. Push to GitHub (this triggers automatic build!)
git push origin setup-release-workflow
git push origin v1.0.0
```

## That's it! 🎉

GitHub Actions will automatically:
- ✅ Build your C# project
- ✅ Create a release
- ✅ Upload Cal.exe

## Download Link:
👉 **https://github.com/dhruvprajapati6/Cal/releases**

Users can download and run Cal.exe directly!

---

## Version Examples:
- `v1.0.0` - First release
- `v1.0.1` - Bug fix
- `v1.1.0` - New feature
- `v2.0.0` - Major update
