/* The file is part of Snowman decompiler. */
/* See doc/licenses.asciidoc for the licensing information. */

//
// SmartDec decompiler - SmartDec is a native code to C++ decompiler
// Copyright (C) 2015 Alexander Chernov, Katerina Troshina, Yegor Derevenets,
// Alexander Fokin, Sergey Levin, Leonid Tsvetkov
//
// This file is part of SmartDec decompiler.
//
// SmartDec decompiler is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SmartDec decompiler is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SmartDec decompiler.  If not, see <http://www.gnu.org/licenses/>.
//

#include "Edge.h"

#include <algorithm>

#include "Node.h"

namespace nc {
namespace core {
namespace ir {
namespace cflow {

Edge::Edge(Node *tail, Node *head):
    tail_(nullptr), head_(nullptr)
{
    setTail(tail);
    setHead(head);
}

void Edge::setTail(Node *tail) {
    if (tail_) {
        tail_->outEdges_.erase(std::find(tail_->outEdges_.begin(), tail_->outEdges_.end(), this));
    }
    tail_ = tail;
    if (tail_) {
        tail_->outEdges_.push_back(this);
    }
}

void Edge::setHead(Node *head) {
    if (head_) {
        head_->inEdges_.erase(std::find(head_->inEdges_.begin(), head_->inEdges_.end(), this));
    }
    head_ = head;
    if (head_) {
        head_->inEdges_.push_back(this);
    }
}

} // namespace cflow
} // namespace ir
} // namespace core
} // namespace nc

/* vim:set et sts=4 sw=4: */
