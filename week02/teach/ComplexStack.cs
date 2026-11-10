public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') { // If the item is an opening bracket, push it onto the stack
                stack.Push(item);
            }
            else if (item is ')') { // 
                if (stack.Count == 0 || stack.Pop() != '(') // If the stack is empty or the top of the stack is not a matching opening bracket, return false
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}