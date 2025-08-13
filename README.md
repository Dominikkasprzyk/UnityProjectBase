# Unity Project Base - Starter Template & Best Practices for New Unity Projects

A **ready-to-use Unity boilerplate project** designed to save hours of setup time. This template includes:

- Pre-installed **essential Unity packages** (Dependency Injection, tweening, localization, camera tools, async utilities).
- A **comprehensive C# coding style guide** for Unity development.
- Clear **asset naming conventions** and **project organization rules**.
- Best practices for **scene hierarchy**, **script structure**, and **version control**.

Whether you’re building a **2D mobile game**, a **3D prototype**, or a **full production title**, this template gives you a **solid, scalable starting point** so you can focus on game logic instead of repetitive setup work.

<a name="table-of-contents"></a>
## 📜 Table of Contents
✂⬇️- - - - - - - - - - - - - - - - - - - - - - - - - - - - -
#### 0. [Getting Started](#how_to)
> 0.1. [What is this project?](#what_is)  
> 0.2. [What's included](#whats_inside)  
> 0.3. [Quickstart guide](#quickstart)

✂⬆️- - - - - - - - - - - - - - - - - - - - - - - - - - - - -

#### 1. [Asset Workflow Rules](#asset_rules)
> 1.1. [General asset rules](#general_asset_rules)  
> 1.2. [Naming](#general_naming)  
> 1.3. [Project structure](#project_struct)  
> 1.4. [Scene structure](#scene_struc)  

#### 2. [Coding Standards](#coding_rules)
> 2.1. [General coding rules](#general_coding)  
> 2.2. [Scripts structure](#scripts_struct)  
>> 2.2.1. [Classes](#scr_classes)  
>> 2.2.2. [Variables](#scr_var)  
>> 2.2.3. [Functions, Events, and Event Dispatchers](#scr_func)

✂⬇️- - - - - - - - - - - - - - - - - - - - - - - - - - - - -
<a name="how_to"></a>
## 0. Getting Started

<a name="what_is"></a>
### 0.1 What is this project?

This is my **Unity boilerplate project** for jumpstarting new games or prototypes. It serves as:

- A **ready-to-copy Unity template** with pre-installed, free, high-quality packages.
- A **set of rules** for working with Unity projects.
- A **guide** for essential packages.
- A **walkthrough** for setting up new projects.
- **All of the above** in one place.

I recommend using the latest Unity LTS version to ensure maximum stability and compatibility with all included packages. This project uses Unity version 6000.0.55f1, which is the latest LTS release as of today.

**[⬆ Back to Top](#table-of-contents)**

<a name="whats_inside"></a>
### 0.2. What’s Included?

#### 0.2.1. Core Systems
This template contains only **universally useful systems** I use in nearly every Unity project:

- **Dependency Injection** - [VContainer](https://vcontainer.hadashikick.jp/) – Lightweight, high-performance DI with full control over bindings.

- **Tweening**
[PrimeTween](https://github.com/KyryloKuzyk/PrimeTween) – Zero-allocation C# delegate-based tweening, intuitive and free.

- **Localization Support**
Unity's official [Localization package](https://docs.unity3d.com/Packages/com.unity.localization@latest) paired with Google Sheets integration.
All in-game text is set up for localization from the start, avoiding last-minute headaches.

- **Other Tools**
  - [Cinemachine](https://unity.com/features/cinemachine) – Official Unity camera system.
  - [MessagePipe](https://github.com/Cysharp/MessagePipe) – High-performance messaging pipeline, integrates with VContainer.
  - [UniTask](https://github.com/Cysharp/UniTask) – Allocation-free async/await integration for Unity.

- **More Recommended Tools (Not Included in This Project)**

  - [Sirenix Odin Inspector](https://odininspector.com/) - A powerful editor extension I personally use in nearly every project for enhanced inspector customization and productivity.

#### 0.2.2. Development Rules
- **Asset workflow rules** – Inspired by the [Unity Style Guide](https://github.com/justinwasilenko/Unity-Style-Guide).
- **Coding standards** – A mix of universal programming principles, Unity-specific tips, and my personal style guidelines.

**[⬆ Back to Top](#table-of-contents)**

<a name="quickstart"></a>
### 0.3 Quickstart Guide

This guide will help you decide how to best use this project base according to your needs.

**How do you want to use this project?**

1. **Use this project as a complete base with all its content:**
   - Click the green **"Use this template"** button at the top of the repository page to create your own repository based on this template.
   - Follow the steps from section below - [*2. Use the README with rules in your existing project*](#use_readme) - to customize the README, update rules, and tailor the project to your needs.
<a name="use_readme"></a>
3. **Use the README with rules in your existing project:**
    - Remove section 0 (this introduction) to keep the rules as the core content.
    - Update the project title and description to reflect your project.
    - Adjust asset and coding rules as needed to fit your current workflows.
    - Use these rules as a style guide to improve consistency and collaboration within your team.

4. **Set up your own project with a custom configuration:**
    - Create a new Unity project with your preferred Unity version.
    - Selectively add only the systems or packages you need (for example, Dependency Injection or Localization).
	- Copy the README file into your project repository.
    - Follow the steps from section above - [*2. Use the README with rules in your existing project*](#use_readme) - to customize the README, update rules, and tailor the project to your needs.

**[⬆ Back to Top](#table-of-contents)**

✂⬆️- - - - - - - - - - - - - - - - - - - - - - - - - - - - -
<a name="asset_rules"></a>
## 1. Asset Workflow Rules

<a name="general_asset_rules"></a>
### 1.1. General Rules

- **Localize all text** - Every in-game text must be stored in the localization Google Sheet.
- **Use ScriptableObjects for configuration** - Keep variables outside logic scripts.
- **Organize scene hierarchy** - Logical grouping for readability.

**[⬆ Back to Top](#table-of-contents)**

<a name="general_naming"></a>
#### 1.2. Naming
- **No default names** – Avoid “Cube (1)” or “NewPrefab”.
- **PascalCase for assets** – No spaces, symbols, or Unicode. Example: `RocketPistol`.
- **Context in mind** - Short, recognizable names based on context.
- **Variants** - Variants use _VariantName or numbered suffix for generics (Rock_01, Rock_02, Bob_Evil, Bob_Retro).

**[⬆ Back to Top](#table-of-contents)**

<a name="project_struct"></a>
## 1.3. Project Structure
<pre>
Assets
    Art
    Audio
	Plugins
    Prefabs
        Example
            _BaseExample.prefab
            FirstExample.prefab
            SecondExample.prefab
    Scenes
    Scripts
        Gameplay
            ExampleSystem
                API
                    IExample.cs
                Impl
                    Example.cs
        Tools
    Settings
</pre>

**[⬆ Back to Top](#table-of-contents)**

<a name="scene_struc"></a>
## 1.4. Scene structure
<pre>
@SceneContext
    ExampleScope
@Systems
    ExampleSystem
@Debug
    ExampleDebug
...
</pre>

Use @ as a prefix for empty objects used only as script containers.

**[⬆ Back to Top](#table-of-contents)**

<a name="coding_rules"></a>
## 2. Rules for Coding

<a name="general_coding"></a>
### 2.1. General Coding Rules

<a name="design_principles"></a>
#### 2.1.1. Design Principles
- **Single Responsibility (S in SOLID)** - A class/module should have one clear purpose.
- **Open/Closed Principle (O in SOLID)** - Open for extension, closed for modification.
- **Liskov Substitution Principle (L in SOLID)** - Subclasses should work as their base type without altering behavior.
- **Interface Segregation Principle (I in SOLID)** - Use multiple small, specific interfaces instead of large, general ones.
- **Dependency Inversion Principle (D in SOLID)** - Depend on abstractions, not concrete implementations.
- **DRY (Don't Repeat Yourself)** - Extract reusable code to avoid duplication.
- **KISS (Keep It Simple, Stupid)** - Avoid unnecessary complexity.
- **YAGNI (You Aren't Gonna Need It)** - Don't add features before they’re needed.

**[⬆ Back to Top](#table-of-contents)**

<a name="coding_style"></a>
#### 2.1.2. Coding Style
- **Descriptive naming** - Use meaningful names following conventions (PascalCase and camelCase for private and local variables).
- **Consistency over preference** - Follow project style rules even if you prefer another approach.
- **Short functions** - Keep functions concise (ideally under 20 lines).
- **Reasonable class size** - Refactor classes that become too large.
- **Separate data from behavior** - Keep data structures independent from logic.

**[⬆ Back to Top](#table-of-contents)**

<a name="csharp_guidelines"></a>
#### 2.1.3. C#-Specific Guidelines
- **Use `var` for obvious types** - Improves readability without losing clarity.
- **Use LINQ wisely** - Great for readability but avoid in performance-critical paths.
- **Minimize allocations** - Avoid unnecessary object creation, especially in tight loops.

**[⬆ Back to Top](#table-of-contents)**

<a name="unity_guidelines"></a>
#### 2.1.4. Unity-Specific Guidelines
- **Separate logic from MonoBehaviours** - Keep core logic in pure C# classes.
- **Prefer composition over inheritance** - Build behavior by combining components instead of deep hierarchies.
- **Optimize Update methods** - Keep them lightweight and avoid unnecessary per-frame work.
- **Cache component references** - Use `Awake`/`Start` to store `GetComponent` results.
- **Use events over direct references** - Improves decoupling between systems.
- **Serialized private fields** - Use `[SerializeField] private` for inspector-only fields.
- **Object pooling** - Reuse objects instead of constant instantiation/destruction.

**[⬆ Back to Top](#table-of-contents)**

<a name="collaboration_version_control"></a>
#### 2.1.5. Collaboration & Version Control
- **Frequent, focused commits** - Each commit should represent a complete, logical change.
- **Clear commit messages** - State *what* changed and *why*.
- **Regular merges** - Keep your branch up to date to avoid conflicts.

**[⬆ Back to Top](#table-of-contents)**

<a name="maintainability_scalability"></a>
#### 2.1.6. Maintainability & Scalability
- **Code for change** - Write code that can be extended without major rewrites.
- **Minimal dependencies** - Keep systems loosely coupled.
- **Interfaces & events for decoupling** - Avoid hardcoded dependencies.
- **Data-driven design** - Configure systems via ScriptableObjects.

**[⬆ Back to Top](#table-of-contents)**

<a name="scripts_struct"></a>
### 2.2. Scripts structure

<a name="scr_classes"></a>
#### 2.2.1. Classes
- **Separate API for systems** - Use interface to refer to a class from outside of its namespace.

- **Namespace** - Namespace should match script localization in project structure.

-  **Multiple classes in files** - Source files should contain only one public type, although multiple internal classes are allowed.

- **File name** - Source files should be given the name of the public class in the file.

- **Interfaces** - Interfaces names are led with a capital `I`.
Example: ```public interface IInterface { }```

- **Group class members in logical sections** - events next to events, lifetime methods next to lifetime methods etc.

```
namespace Gameplay/ExampleSystem/Impl
{
    public class Example : IExample, MonoBehaviour
    {
        [Inject]
        private IInjectedExample _injectedExample;

        [SerializeField]
        private Example _exampleSerializeField;

        private int _examplePrivateField = 2;

        public int ExamplePublicField => _examplePrivateField;

        public event Action ExampleEvent;

        private void Start()
        {
            _exampleSerializeField?.ExampleEvent += ExamplePrivateMethod;
        }

        private void OnDestroy()
        {
            _exampleSerializeField?.ExampleEvent -= ExamplePrivateMethod;
        }

        private void ExamplePrivateMethod()
        {
            var variableExample = 0;
        }

        public void ExamplePublicMethod()
        {
        }
    }
    
    [Serializable]
    public class ExampleSub
    {
    }
}
```

**[⬆ Back to Top](#table-of-contents)**

<a name="scr_var"></a>
#### 2.2.2. Variables

- **Var** - Use var instead of explicit types whenever possible.

- **Nouns** - Non-boolean variables are nouns; 

- **Booleans** - Booleans are prefixed with verb (isDead, hasItem).

- **Case** - All variables use PascalCase unless marked as private which use _camelCase or local which use camelCase. 

- **Considered Context** - Avoid redundant context in names. Example: class `Enemy` should have variable named  `IsDead`  instead of   `IsEnemyDead`.

**[⬆ Back to Top](#table-of-contents)**

<a name="scr_func"></a>
#### 2.2.3 Functions, Events, and Event Dispatchers

- **Verbs in present tense**
    All functions should start with verbs and be worded in the present tense whenever possible. They should also have some context as to what they are doing. 
	**Good examples**: `Explode`, `IsEnemy`. 
	**Bad examples**: `Dead` (Is Dead? Will deaden?), `ProcessData` (Ambiguous, these words mean nothing).

- **Functions Returning Bool Should Ask Questions** - When writing a function for getting information, state, or computing a yes/no value, it should ask a question.
**Good examples**: `IsDead`, `HasWeapon`, `WasLoading`, `CanJump`.
**Bad examples**: `Fire` (Is on fire? Will fire? Do fire?), `OnFire` (Can be confused with event dispatcher for firing).

- **Event Handlers and Dispatchers Should Start With `On`** - Any function that handles an event or dispatches an event should start with `On`.

**[⬆ Back to Top](#table-of-contents)**
