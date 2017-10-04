var _value;
var _left;
var _right;

function TreeNode(value, left, right) {
    _value = value;
    _left = left || null;
    _right = right || null;
}

TreeNode.prototype.getValue = function () {
    return _value;
};

TreeNode.prototype.getLeft = function () {
    return _left;
};

TreeNode.prototype.getRight = function () {
    return _right;
};