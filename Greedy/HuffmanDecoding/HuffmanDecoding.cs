namespace HuffmanDecoding
{
    public class HuffmanDecoding
    {
        static string DecodeHuffmanData(TreeNode root, string binaryString)
        {
            var decodedString = string.Empty;
            if (root != null)
            {
                var currNode = root;
                int n = binaryString.Length;
                for (int i = 0; i < n; i++)
                {
                    if (binaryString[i] == '0')
                    {
                        currNode = currNode.Left;
                    }
                    else if (binaryString[i] == '1')
                    {
                        currNode = currNode.Right;
                    }
                    if (currNode.Left == null && currNode.Right == null) 
                    {
                        decodedString += currNode.Data;
                        currNode = root;
                    }
                }    
            }
            
            return decodedString;
        }
    }
}