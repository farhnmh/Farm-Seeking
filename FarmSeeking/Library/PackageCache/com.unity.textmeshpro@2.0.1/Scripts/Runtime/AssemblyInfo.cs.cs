<<<<<<< HEAD
﻿using System.Runtime.CompilerServices;

// Allow internal visibility for testing purposes.
[assembly: InternalsVisibleTo("Unity.TextCore")]

[assembly: InternalsVisibleTo("Unity.FontEngine.Tests")]

#if UNITY_EDITOR
[assembly: InternalsVisibleTo("Unity.TextCore.Editor")]
[assembly: InternalsVisibleTo("Unity.TextMeshPro.Editor")]
#endif
=======
﻿using System.Runtime.CompilerServices;

// Allow internal visibility for testing purposes.
[assembly: InternalsVisibleTo("Unity.TextCore")]

[assembly: InternalsVisibleTo("Unity.FontEngine.Tests")]

#if UNITY_EDITOR
[assembly: InternalsVisibleTo("Unity.TextCore.Editor")]
[assembly: InternalsVisibleTo("Unity.TextMeshPro.Editor")]
#endif
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
