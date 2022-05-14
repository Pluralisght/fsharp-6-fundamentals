Enumerable.Range(1, 5)
    .Where(i => i % 2 ==0) // filter
    .Select(i => i * 2) // map
    .Sum(); // aggregate
notepad